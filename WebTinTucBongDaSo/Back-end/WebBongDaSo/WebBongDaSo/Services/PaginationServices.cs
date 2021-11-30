using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;
using WebBongDaSo.IServices;

namespace WebBongDaSo.Services
{
    public class PaginationServices : IPaginationServices
    {
        private WebBongDaContext dbContext = new WebBongDaContext();
        public int GetTotalOfPage(int chuDeId = 0)
        {
            int pageSize = 15;
            int count = dbContext.BaiViets.Count();
            if (chuDeId != 0)
            {
                count = dbContext.BaiViets.Where(x => x.MaChuDe == chuDeId).Count();
            }

            int totalPage = (count + pageSize - 1) / pageSize;
            return totalPage;
        }
    }
}
