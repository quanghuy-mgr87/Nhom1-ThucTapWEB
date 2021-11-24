using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBongDaSo.Entities
{
    public class BaiViet
    {
        [Key]
        public int MaBaiViet { get; set; }

        [StringLength(100, ErrorMessage = "Tiêu đề không được quá 100 kí tự")]
        public string TieuDe { get; set; }

        [StringLength(200, ErrorMessage = "Mô tả không được quá 200 kí tự")]
        public string MoTa { get; set; }

        public string LinkAnh { get; set; }

        public string NoiDung { get; set; }

        public int MaChuDe { get; set; }

        public string TenTacGia { get; set; }   //Thêm vào mục sửa thông tin bài viết

        [Required(ErrorMessage = "Tài khoản người đăng không được trống")]
        public string TaiKhoanNguoiDang { get; set; } //Thêm vào mục sửa thông tin bài viết

        public DateTime NgayTao { get; set; }

        public DateTime NgayCapNhat { get; set; }

        public virtual ChuDe ChuDe { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }

    }
}
