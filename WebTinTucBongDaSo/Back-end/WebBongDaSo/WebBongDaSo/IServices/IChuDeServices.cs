using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;

namespace WebBongDaSo.IServices
{
    interface IChuDeServices
    {
        List<ChuDe> LayDSChuDe(string tenChuDe = "");
        bool ThemChuDe(ChuDe chuDe);
        bool SuaChuDe(ChuDe chuDe);
        bool XoaChuDe(ChuDe chuDe);
    }
}
