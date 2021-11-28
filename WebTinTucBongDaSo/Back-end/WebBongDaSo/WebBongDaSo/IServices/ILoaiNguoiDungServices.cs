using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;

namespace WebBongDaSo.IServices
{
    interface ILoaiNguoiDungServices
    {
        List<LoaiNguoiDung> LayDSLoaiNguoiDung();
        LoaiNguoiDung LayLoaiNguoiDungTheoMa(int loaiNguoiDungId);
        bool ThemLoaiNguoiDung(LoaiNguoiDung loaiNguoiDung);
        bool SuaLoaiNguoiDung(LoaiNguoiDung loaiNguoiDung);
        bool XoaLoaiNguoiDung(int loaiNguoiDungId);
    }
}
