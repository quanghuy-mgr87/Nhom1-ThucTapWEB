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
    public class NguoiDungController : ControllerBase
    {
        private NguoiDungServices nguoiDungServices = new NguoiDungServices();
        [HttpGet]
        public IActionResult LayDSNguoiDung()
        {
            var lstNguoiDung = nguoiDungServices.LayDSNguoiDung();
            if (lstNguoiDung.Count > 0)
            {
                return Ok(lstNguoiDung);
            }
            else
            {
                return BadRequest("Danh sách trống!");
            }
        }

        [HttpGet]
        [Route("layThongTinTheoTK")]
        public IActionResult LayNguoiDungTheoTaiKhoan(string taiKhoan)
        {
            NguoiDung nguoiDung = nguoiDungServices.LayNguoiDungTheoTaiKhoan(taiKhoan);
            if (nguoiDung == null)
            {
                return BadRequest($"Người dùng {taiKhoan} không tồn tại!");
            }
            else
            {
                return Ok(nguoiDung);
            }
        }

        [HttpGet]
        [Route("layMaLoaiNguoiDung")]
        public IActionResult LayMaLoaiNguoiDung(string taiKhoan)
        {
            NguoiDung nguoiDung = nguoiDungServices.LayNguoiDungTheoTaiKhoan(taiKhoan);
            if (nguoiDung == null)
            {
                return BadRequest($"Người dùng {taiKhoan} không tồn tại!");
            }
            else
            {
                string maLoai = nguoiDungServices.LayMaLoaiNguoiDung(nguoiDung);
                return Ok(maLoai);
            }
        }

        [HttpPost]
        [Route("kiemTraDangNhap")]
        public IActionResult KiemTraDangNhap(NguoiDung nguoiDung)
        {
            var ok = nguoiDungServices.KiemTraDangNhap(nguoiDung);
            if (ok)
            {
                return Ok("Đăng nhập thành công!");
            }
            else
            {
                return BadRequest("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        [HttpPut]
        public IActionResult SuaNguoiDung(NguoiDung nguoiDung)
        {
            bool check = nguoiDungServices.SuaNguoiDung(nguoiDung);
            if (check == true)
            {
                return Ok("Sửa thành công !");
            }
            else
            {
                return BadRequest($"Người dùng có tài khoản {nguoiDung.TaiKhoan} không tồn tại !");
            }
        }
        [HttpPost]
        public IActionResult ThemNguoiDung(NguoiDung nguoiDung)
        {
            bool check = nguoiDungServices.ThemNguoiDung(nguoiDung);
            if (check == true)
            {
                return Ok("Thêm thành công !");
            }
            else
            {
                return BadRequest($"Người dùng có tài khoản {nguoiDung.TaiKhoan} đã tồn tại !");
            }
        }
        [HttpDelete]
        public IActionResult XoaNguoiDung(string taiKhoan)
        {
            bool check = nguoiDungServices.XoaNguoiDung(taiKhoan);
            if (check == true)
            {
                return Ok("Xóa thành công !");
            }
            else
            {
                return BadRequest($"Người dùng có tài khoản {taiKhoan} không tồn tại !");
            }
        }
    }
}
