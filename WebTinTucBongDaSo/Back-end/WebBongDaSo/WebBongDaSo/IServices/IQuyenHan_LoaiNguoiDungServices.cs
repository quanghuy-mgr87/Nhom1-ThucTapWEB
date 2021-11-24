using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;

namespace WebBongDaSo.IServices
{
    interface IQuyenHan_LoaiNguoiDungServices
    {
        List<QuyenHan_LoaiNguoiDung> LayDSQuyenHanLoaiNguoiDung();
        bool ThemQuyenHanLoaiNguoiDung(QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung);
        bool SuaQuyenHanLoaiNguoiDung(QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung);
        bool XoaQuyenHanLoaiNguoiDung(int quyenHan_LoaiNguoiDungId);
    }
}
