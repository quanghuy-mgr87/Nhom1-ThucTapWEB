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
    public class LoaiNguoiDungController : ControllerBase
    {
        private LoaiNguoiDungServices loaiNguoiDungServices = new LoaiNguoiDungServices();
        [HttpGet]
        public IActionResult LayDSLoaiNguoiDung()
        {
            var lstLoaiNguoiDung = loaiNguoiDungServices.LayDSLoaiNguoiDung();
            if(lstLoaiNguoiDung.Count>0)
            {
                return Ok(lstLoaiNguoiDung);
            }
            else
            {
                return BadRequest("Danh sách trống!");
            }
        }
        [HttpPut]
        public IActionResult SuaLoaiNguoiDung(LoaiNguoiDung loaiNguoiDung)
        {
            bool check = loaiNguoiDungServices.SuaLoaiNguoiDung(loaiNguoiDung);
            if(check == true)
            {
                return Ok("Sửa thành công!");
            }    
            else
            {
                return BadRequest($"Loại người dùng có mã loại người dùng là {loaiNguoiDung.LoaiNguoiDungId} không tồn tại !");
            }    
        }
        [HttpPost]
        public IActionResult ThemLoaiNguoiDung(LoaiNguoiDung loaiNguoiDung)
        {
            bool check = loaiNguoiDungServices.ThemLoaiNguoiDung(loaiNguoiDung);
            if(check==true)
            {
                return Ok("Thêm thành công!");
            }    
            else
            {
                return BadRequest($"Loại người dùng {loaiNguoiDung.TenLoai} đã tồn tại!");
            }    
        }
        [HttpDelete]
        public IActionResult XoaLoaiNguoiDung(int loaiNguoiDungId)
        {
            bool check = loaiNguoiDungServices.XoaLoaiNguoiDung(loaiNguoiDungId);
            if(check == true)
            {
                return Ok($"Đã xóa loại người dùng có Id {loaiNguoiDungId}");
            }    
            else
            {
                return BadRequest($"Loại người dùng có ID {loaiNguoiDungId} không tồn tại !");
            }    
        }
    }
}
