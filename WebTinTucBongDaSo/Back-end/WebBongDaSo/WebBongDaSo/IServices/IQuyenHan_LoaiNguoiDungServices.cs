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
        bool ThemChuDe(QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung);
        bool SuaChuDe(QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung);
        bool XoaChuDe(int quyenHan_LoaiNguoiDungId);
    }
}
