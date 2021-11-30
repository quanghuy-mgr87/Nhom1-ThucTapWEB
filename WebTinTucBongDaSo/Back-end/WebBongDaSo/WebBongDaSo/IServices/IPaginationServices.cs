using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBongDaSo.IServices
{
    interface IPaginationServices
    {
        int GetTotalOfPage(int chuDeId = 0);
    }
}
