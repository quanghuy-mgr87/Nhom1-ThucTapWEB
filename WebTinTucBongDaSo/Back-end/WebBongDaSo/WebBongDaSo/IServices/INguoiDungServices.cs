using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;

namespace WebBongDaSo.IServices
{
    interface INguoiDungServices
    {
        List<NguoiDung> LayDSNguoiDung();
        bool ThemNguoiDung(NguoiDung nguoiDung);
        bool SuaNguoiDung(NguoiDung nguoiDung);
        bool XoaNguoiDung(string taiKhoan);
    }
}
