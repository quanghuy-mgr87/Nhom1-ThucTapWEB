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
    public class BaiVietController : ControllerBase
    {
        private BaiVietServices baiVietServices = new BaiVietServices();
        [HttpGet]
        public IActionResult LayDSBaiViet()
        {
            var lstBaiViet = baiVietServices.LayDSBaiViet();
            if (lstBaiViet.Count > 0)
            {
                return Ok(lstBaiViet);
            }
            else
            {
                return BadRequest("Danh sách trống");
            }
        }

        [HttpGet]
        [Route("chi-tiet-bai-viet")]
        public IActionResult TimBaiVietTheoMa(int baiVietId)
        {
            BaiViet baiViet = baiVietServices.TimBaiVietTheoMa(baiVietId);
            if (baiViet == null)
                return BadRequest("Bài viết không tồn tại!");
            return Ok(baiViet);
        }

        [HttpPut]
        public IActionResult SuaBaiViet(BaiViet baiVietUpdate)
        {
            bool check = baiVietServices.SuaBaiViet(baiVietUpdate);
            if (check == true)
            {
                return Ok("Sửa thành công!");
            }
            else
            {
                return BadRequest($"Bài viết có mã bài viết là {baiVietUpdate.MaBaiViet} không tồn tại !");
            }
        }
        [HttpPost]
        public IActionResult ThemBaiViet(BaiViet baiViet)
        {
            bool check = baiVietServices.ThemBaiViet(baiViet);
            if (check == true)
            {
                return Ok("Thêm thành công!");
            }
            else
            {
                return BadRequest($"Tên bài viết {baiViet.TieuDe} đã tồn tại!");
            }
        }
        [HttpDelete]
        public IActionResult XoaBaiViet(BaiViet baiViet)
        {
            bool check = baiVietServices.XoaBaiViet(baiViet);
            if (check == true)
            {
                return Ok($"Đã xóa bài viết có mã {baiViet.MaBaiViet}");
            }
            else
            {
                return BadRequest($"Bài viết có mã {baiViet.MaBaiViet} không tồn tại!");
            }
        }
    }
}
