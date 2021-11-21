using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBongDaSo.Entities
{
    public class WebBongDaContext : DbContext
    {
        public DbSet<BaiViet> BaiViets { get; set; }
        public DbSet<ChuDe> ChuDes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source = .\SQLEXPRESS; initial catalog = WebBongDaDB; integrated security = sspi");
        }
    }
}
