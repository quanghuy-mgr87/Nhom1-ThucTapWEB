﻿using System;
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

        [StringLength(200, ErrorMessage = "Tiêu đề không được quá 200 kí tự")]
        public string MoTa { get; set; }

        public string LinkAnh { get; set; }

        public string NoiDung { get; set; }

        public int MaChuDe { get; set; }

        public DateTime NgayTao { get; set; }

        public virtual ChuDe ChuDe { get; set; }
    }
}
