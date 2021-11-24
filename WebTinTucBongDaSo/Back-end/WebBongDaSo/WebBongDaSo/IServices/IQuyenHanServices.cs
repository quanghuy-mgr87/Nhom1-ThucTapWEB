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
        bool ThemQuyenHan(QuyenHan quyenHan);
        bool SuaQuyenHan(QuyenHan quyenHan);
        bool XoaQuyenHan(int quyenHanId);
    }
}
