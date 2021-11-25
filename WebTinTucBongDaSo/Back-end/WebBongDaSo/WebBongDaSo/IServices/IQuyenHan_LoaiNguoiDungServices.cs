using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;

namespace WebBongDaSo.IServices
{
    interface IQuyenHan_LoaiNguoiDungServices
    {
        List<QuyenHan_LoaiNguoiDung> LayDSQuyenHan_LoaiNguoiDung();
        bool ThemQuyenHan_LoaiNguoiDung(QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung);
        bool SuaQuyenHan_LoaiNguoiDung(QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung);
        bool XoaQuyenHan_LoaiNguoiDung(int quyenHan_LoaiNguoiDungId);
    }
}
