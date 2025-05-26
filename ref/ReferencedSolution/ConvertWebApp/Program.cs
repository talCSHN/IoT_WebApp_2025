namespace ConvertWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // HttpClient 등록
            builder.Services.AddHttpClient("MyWebClient", client =>
            {
                client.BaseAddress = new Uri("http://localhost:8000"); // AI 기본주소
            });

            // CORS 허용 (로컬 테스트용)
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            builder.Services.AddControllers();
            var app = builder.Build();

            app.UseCors();
            // wwwroot/index.html 같은 정적 파일을 서빙할 수 있도록 설정
            app.UseDefaultFiles();  // index.html 자동 처리
            app.UseStaticFiles();   // wwwroot 서빙 허용
            app.MapControllers();
            app.Run();
        }
    }
}
