using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBongDaSo.Entities
{
    public class QuyenHan
    {
        public int QuyenHanId { get; set; }

        [StringLength(20,ErrorMessage ="Tên quyền hạn không được quá 20 kí tự")]
        public string TenQuyenHan { get; set; }
        public virtual IEnumerable<QuyenHan_LoaiNguoiDung> QuyenHan_LoaiNguoiDungs { get; set; }
    }
}
