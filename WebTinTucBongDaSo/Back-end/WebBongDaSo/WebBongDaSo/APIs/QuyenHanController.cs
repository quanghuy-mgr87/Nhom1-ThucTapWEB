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
    public class QuyenHanController : ControllerBase
    {
        private QuyenHanServices quyenHanServices = new QuyenHanServices();
        [HttpGet]
        public IActionResult LayDSQuyenHan()
        {
            var lstQuyenHan = quyenHanServices.LayDSQuyenHan();
            if(lstQuyenHan.Count>0)
            {
                return Ok(lstQuyenHan);
            }
            else
            {
                return BadRequest("Danh sách trống !");
            }
        }
        [HttpPut]
        public IActionResult SuaQuyenHan(QuyenHan quyenHan)
        {
            bool check = quyenHanServices.SuaQuyenHan(quyenHan);
            if(check == true)
            {
                return Ok("Sửa thành công!");
            }    
            else
            {
                return BadRequest($"Quyền hạn có Id {quyenHan.QuyenHanId} không tồn tại !");
            }    
        }
        [HttpPost]
        public IActionResult ThemQuyenHan(QuyenHan quyenHan)
        {
            bool check = quyenHanServices.ThemQuyenHan(quyenHan);
            if(check == true)
            {
                return Ok("Thêm thành công!");
            }    
            else
            {
                return BadRequest($"Quyền hạn có Id {quyenHan.QuyenHanId} đã tồn tại !");
            }    
        }
        [HttpDelete]
        public IActionResult XoaQuyenHan(int quyenHanId)
        {
            bool check = quyenHanServices.XoaQuyenHan(quyenHanId);
            if(check == true)
            {
                return Ok("Xóa thành công!");
            }
            else
            {
                return BadRequest($"Quyền hạn có Id {quyenHanId} không tồn tại !");
            }
        }
    }
}
