using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;
using WebBongDaSo.Services;

namespace WebBongDaSo.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuDeController : ControllerBase
    {
        private ChuDeServices chuDeService = new ChuDeServices();
        [HttpGet]
        public IActionResult LayDSChuDe()
        {
            var lstChuDe = chuDeService.LayDSChuDe();
            if(lstChuDe.Count >0)
            {
                return Ok(lstChuDe);
            }    
            else
            {
                return BadRequest("Danh sách trống!");
            }    
        }
        [HttpPut]
        public IActionResult SuaChuDe(ChuDe chuDeUpdate)
        {
            bool check = chuDeService.SuaChuDe(chuDeUpdate);
            if (check == true)
            {
                return Ok("Sửa thành công!");
            }
            else
            {
                return BadRequest($"Chủ đề có mã chủ đề là {chuDeUpdate.MaChuDe} không tồn tại !");
            }
        }
        [HttpPost]
        public IActionResult ThemChuDe(ChuDe chuDe)
        {
            bool check = chuDeService.ThemChuDe(chuDe);
            if (check == true)
            {
                return Ok("Thêm thành công!");
            }
            else
            {
                return BadRequest($"Tên chủ đề {chuDe.TenChuDe} đã tồn tại!");
            }
        }
        [HttpDelete]
        public IActionResult XoaChuDe(int maChuDe)
        {
            bool check = chuDeService.XoaChuDe(maChuDe);
            if (check == true)
            {
                return Ok($"Đã xóa chủ đề có mã {maChuDe}");
            }
            else
            {
                return BadRequest($"Chủ đề có mã {maChuDe} không tồn tại!");
            }
        }
    }
}
