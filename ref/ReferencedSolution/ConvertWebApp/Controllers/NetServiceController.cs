using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace ConvertWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NetServiceController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public NetServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost]
        [Route("/net_service")]
        public async Task<IActionResult> ProxyRequest([FromForm] string message, [FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest(new { message = "파일이 없습니다." });
            }

            var client = _httpClientFactory.CreateClient("MyWebClient");

            using var content = new MultipartFormDataContent();

            // 문자열 추가
            content.Add(new StringContent(message), "message");

            // 파일 스트림 추가
            using var stream = file.OpenReadStream();
            var fileContent = new StreamContent(stream);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
            content.Add(fileContent, "file", file.FileName);

            // 내부 API로 요청 전송
            var response = await client.PostAsync("/detect", content);
            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, "내부 API 호출 실패");
            }

            var result = await response.Content.ReadAsStringAsync();
            return Content(result, "application/json");
        }
    }
}
