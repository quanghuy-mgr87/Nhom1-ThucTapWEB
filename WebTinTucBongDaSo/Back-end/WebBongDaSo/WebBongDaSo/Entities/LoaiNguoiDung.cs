using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBongDaSo.Entities
{
    public class LoaiNguoiDung
    {
        public int LoaiNguoiDungId { get; set; }
        [Required]
        [StringLength(10,ErrorMessage = "Mã loại không được quá 10 kí tự")]
        public string MaLoai { get; set; }

        [StringLength(20,ErrorMessage = "Tên loại không được quá 20 kí tự")]
        public string TenLoai { get; set; }
        public virtual IEnumerable<QuyenHan_LoaiNguoiDung> QuyenHan_LoaiNguoiDungs { get; set; }
        public virtual IEnumerable<NguoiDung> NguoiDungs { get; set; }
    }
}
