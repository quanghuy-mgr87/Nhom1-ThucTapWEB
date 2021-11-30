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
        public IActionResult LayDSBaiViet(int pageNumber = 1, int pageSize = int.MaxValue, string tieuDe = "", string taiKhoan = "", int maChuDe = 0)
        {
            Pagination pagination = new Pagination();
            pagination.PageNumber = pageNumber;
            pagination.PageSize = pageSize;

            var lstBaiViet = baiVietServices.LayDSBaiViet(pagination, tieuDe, taiKhoan, maChuDe);
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
        [Route("bai-viet-moi-nhat")]
        public IActionResult TimBaiVietMoiNhat()
        {
            var baiViet = baiVietServices.TimBaiVietMoiNhat();
            if (baiViet != null)
            {
                return Ok(baiViet);
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
        public IActionResult XoaBaiViet(int maBaiViet)
        {
            bool check = baiVietServices.XoaBaiViet(maBaiViet);
            if (check == true)
            {
                return Ok($"Đã xóa bài viết có mã {maBaiViet}");
            }
            else
            {
                return BadRequest($"Bài viết có mã {maBaiViet} không tồn tại!");
            }
        }
    }
}
