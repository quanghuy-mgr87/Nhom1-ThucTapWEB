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
        public DbSet<LoaiNguoiDung> LoaiNguoiDungs { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<QuyenHan> QuyenHans { get; set; }
        public DbSet<QuyenHan_LoaiNguoiDung> QuyenHan_LoaiNguoiDungs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source = LAPTOP-3P0EEUAO; initial catalog = WebBongDaDB; integrated security = sspi");
        }
    }
}
