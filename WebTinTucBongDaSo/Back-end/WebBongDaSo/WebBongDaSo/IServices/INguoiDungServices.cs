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
        bool ThemLoaiNguoiDung(NguoiDung nguoiDung);
        bool SuaLoaiNguoiDung(NguoiDung nguoiDung);
        bool XoaLoaiNguoiDung(int nguoiDungId);
    }
}
