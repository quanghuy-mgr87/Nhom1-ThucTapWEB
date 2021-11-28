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
        NguoiDung LayNguoiDungTheoTaiKhoan(string taiKhoan);
        string LayMaLoaiNguoiDung(NguoiDung nguoiDung);
        bool KiemTraDangNhap(NguoiDung nguoiDung);
        bool ThemNguoiDung(NguoiDung nguoiDung);
        bool SuaNguoiDung(NguoiDung nguoiDung);
        bool XoaNguoiDung(string taiKhoan);
    }
}
