using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBongDaSo.Entities
{
    public class NguoiDung
    {
        [Key]
        [Required(ErrorMessage = "Tên tài khoản không được trống")]
        [StringLength(40, ErrorMessage = "Tên tài khoản không được quá 40 kí tự")]
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

        [StringLength(30, ErrorMessage = "Họ tên không quá 30 kí tự")]
        public string HoTen { get; set; }

        [StringLength(10, ErrorMessage = "Giới tính không quá 10 kí tự")]
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime ThoiGianThamGia { get; set; }
        public int LoaiNguoiDungId { get; set; }
        public virtual LoaiNguoiDung LoaiNguoiDung { get; set; }
        public virtual IEnumerable<BaiViet> BaiViets { get; set; }
    }
}
