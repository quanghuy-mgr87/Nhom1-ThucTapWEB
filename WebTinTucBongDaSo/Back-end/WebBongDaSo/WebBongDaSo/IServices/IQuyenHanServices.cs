using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;

namespace WebBongDaSo.IServices
{
    interface IQuyenHanServices
    {
        List<QuyenHan> LayDSQuyenHan();
        bool ThemChuDe(QuyenHan quyenHan);
        bool SuaChuDe(QuyenHan quyenHan);
        bool XoaChuDe(int quyenHanId);
    }
}
