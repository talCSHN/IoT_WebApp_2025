using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiApp03.Models;

namespace WebApiApp03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IoTDatasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public IoTDatasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/IoTDatas
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<iot_datas>>> GetIoTDatas()
        //{
        //    return await _context.iot_datas.ToListAsync();
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<iot_datas>>> GetIoTDatas(string serviceKey, string startDate, string endDate, string resultType)
        {
            // 실제 데이터포털(data.go.kr)에서 사용하는 방법
            // 1. 서비스키가 일치하는 요청만 수행
            if (string.IsNullOrWhiteSpace(serviceKey))
            {
                return BadRequest();
            }
            else
            {
                // 서버에서 키를 검색해서 유효한 키인지 확인하고 맞으면 진행
            }
            // 2. pageNo, numOfRows 파라미터가 있으면, 실제 데이터를 페이징해서 데이터를 돌려받음
            Debug.WriteLine(startDate, endDate);
            var result = await _context.iot_datas.FromSql($"SELECT * FROM iot_datas WHERE sensing_dt BETWEEN {startDate} AND {endDate}").ToListAsync();
            // 3. resultType이 xml / json 여부에 때라 리턴하는 데이터 타입 변경
            if (resultType == "xml")
            {
                // XML로 형변환
            }
            else if (resultType == "json")
            {
                // JSON으로 형변환
            }
            return result;  // _context.iot_datas.ToListAsync();
        }

        // GET: api/IoTDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<iot_datas>> GetIoTDatas(int id)
        {
            var ioTDatas = await _context.iot_datas.FindAsync(id);

            if (ioTDatas == null)
            {
                return NotFound();
            }

            return ioTDatas;
        }

        //// PUT: api/IoTDatas/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutIoTDatas(int id, iot_datas ioTDatas)
        //{
        //    if (id != ioTDatas.id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(ioTDatas).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!IoTDatasExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/IoTDatas
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<iot_datas>> PostIoTDatas(iot_datas ioTDatas)
        //{
        //    _context.iot_datas.Add(ioTDatas);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetIoTDatas", new { id = ioTDatas.id }, ioTDatas);
        //}

        //// DELETE: api/IoTDatas/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteIoTDatas(int id)
        //{
        //    var ioTDatas = await _context.iot_datas.FindAsync(id);
        //    if (ioTDatas == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.iot_datas.Remove(ioTDatas);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool IoTDatasExists(int id)
        //{
        //    return _context.iot_datas.Any(e => e.id == id);
        //}
    }
}
