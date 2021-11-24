using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBongDaSo.Helper
{
    public class TaiKhoanHelper
    {
        public static string ChuanHoaHoTen(string oldName)
        {
            string newName = "";
            List<String> lstStr = oldName.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Substring(0, 1).ToUpper() + x.Substring(1).ToLower()).ToList();
            lstStr.ForEach(x => newName += x + " ");
            return newName.Trim();
        }
    }
}