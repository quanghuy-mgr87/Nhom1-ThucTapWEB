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
    public class QuyenHan_LoaiNguoiDungController : ControllerBase
    {
        private QuyenHan_LoaiNguoiDungServices quyenHan_LoaiNguoiDungServices = new QuyenHan_LoaiNguoiDungServices();
        [HttpGet]
        public IActionResult LayDSQuyenHan_LoaiNguoiDung()
        {
            var lstQuyenHan_LoaiNguoiDung = quyenHan_LoaiNguoiDungServices.LayDSQuyenHan_LoaiNguoiDung();
            if(lstQuyenHan_LoaiNguoiDung.Count>0)
            {
                return Ok(lstQuyenHan_LoaiNguoiDung);
            }    
            else
            {
                return BadRequest("Danh sách trống !");
            }    
        }
        [HttpPut]
        public IActionResult SuaQuyenHan_LoaiNguoiDung(QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung)
        {
            bool check = quyenHan_LoaiNguoiDungServices.SuaQuyenHan_LoaiNguoiDung(quyenHan_LoaiNguoiDung);
            if(check == true)
            {
                return Ok("Sủa thành công !");
            }    
            else
            {
                return BadRequest($"Quyền hạn loại người dùng có Id {quyenHan_LoaiNguoiDung.Id} không tồn tại !");
            }    
        }
        [HttpPost]
        public IActionResult ThemQuyenHan_LoaiNguoiDung(QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung)
        {
            bool check = quyenHan_LoaiNguoiDungServices.ThemQuyenHan_LoaiNguoiDung(quyenHan_LoaiNguoiDung);
            if(check == true)
            {
                return Ok("Thêm thành công !");
            }    
            else
            {
                return BadRequest($"Quyền hạn loại người dùng có Id {quyenHan_LoaiNguoiDung.Id} đã tồn tại !");
            }    
        }
        [HttpDelete]
        public IActionResult XoaQuyenHan_LoaiNguoiDung(int quyenHan_LoaiNguoiDungId)
        {
            bool check = quyenHan_LoaiNguoiDungServices.XoaQuyenHan_LoaiNguoiDung(quyenHan_LoaiNguoiDungId);
            if(check == true)
            {
                return Ok("Xóa thành công!");
            }
            else
            {
                return BadRequest($"Quyền hạn loại người dùng có Id {quyenHan_LoaiNguoiDungId} không tồn tại !");
            }    
        }
    }
}
