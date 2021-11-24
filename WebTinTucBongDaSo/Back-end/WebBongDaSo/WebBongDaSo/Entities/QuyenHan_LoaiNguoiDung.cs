using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBongDaSo.Entities
{
    public class QuyenHan_LoaiNguoiDung
    {
        public int Id { get; set; }
        public int QuyenHanId { get; set; }
        public int LoaiNguoiDungId { get; set; }
        public virtual QuyenHan QuyenHan { get; set; }
        public virtual LoaiNguoiDung LoaiNguoiDung { get; set; }
    }
}
