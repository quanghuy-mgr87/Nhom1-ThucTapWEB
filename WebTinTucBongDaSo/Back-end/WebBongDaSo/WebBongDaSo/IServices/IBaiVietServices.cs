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
        BaiViet TimBaiVietTheoMa(int baiVietId);
        BaiViet TimBaiVietMoiNhat();
        bool ThemBaiViet(BaiViet baiViet);
        bool SuaBaiViet(BaiViet baiViet);
        bool XoaBaiViet(int maBaiViet);
        void CapNhatSoLuongBaiViet(ChuDe chuDe);
    }
}
