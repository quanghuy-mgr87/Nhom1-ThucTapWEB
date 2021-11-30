using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;

namespace WebBongDaSo.IServices
{
    interface IBaiVietServices
    {
        List<BaiViet> LayDSBaiViet(Pagination pagination = null, string tieuDe = "", string taiKhoan = "", int maChuDe = 0);
        BaiViet TimBaiVietTheoMa(int baiVietId);
        BaiViet TimBaiVietMoiNhat();
        bool ThemBaiViet(BaiViet baiViet);
        bool SuaBaiViet(BaiViet baiViet);
        bool XoaBaiViet(int maBaiViet);
        void CapNhatSoLuongBaiViet(ChuDe chuDe);
    }
}
