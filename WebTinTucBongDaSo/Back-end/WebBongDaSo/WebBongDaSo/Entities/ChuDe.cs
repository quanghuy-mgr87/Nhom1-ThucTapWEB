using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBongDaSo.Entities
{
    public class ChuDe
    {
        [Key]
        public int MaChuDe { get; set; }

        [StringLength(50, ErrorMessage = "Tên chủ đề không được quá 50 kí tự!")]
        public string TenChuDe { get; set; }

        public int SoLuongBaiViet { get; set; }

        public virtual IEnumerable<BaiViet> BaiViets { get; set; }
    }
}
