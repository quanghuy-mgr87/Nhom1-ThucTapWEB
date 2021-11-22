using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;

namespace WebBongDaSo.IServices
{
    interface IBaiVietServices
    {
        List<BaiViet> LayDSBaiViet(string tieuDe = "");
        bool ThemBaiViet(BaiViet baiViet);
        bool SuaBaiViet(BaiViet baiViet);
        bool XoaBaiViet(BaiViet baiViet);
        void CapNhatSoLuongBaiViet(ChuDe chuDe);
    }
}
