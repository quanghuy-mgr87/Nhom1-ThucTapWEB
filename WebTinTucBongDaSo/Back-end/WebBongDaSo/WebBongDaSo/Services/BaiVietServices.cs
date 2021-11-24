using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;
using WebBongDaSo.IServices;

namespace WebBongDaSo.Services
{
    public class BaiVietServices : IBaiVietServices
    {
        private WebBongDaContext dbContext = new WebBongDaContext();

        public void CapNhatSoLuongBaiViet(ChuDe chuDe)
        {
            List<BaiViet> lstBaiViet = dbContext.BaiViets.ToList();
            int dem = 0;
            for (int i = 0; i < lstBaiViet.Count; i++)
            {
                if (lstBaiViet[i].MaChuDe == chuDe.MaChuDe)
                {
                    dem++;
                }
            }
            chuDe.SoLuongBaiViet = dem;
            dbContext.ChuDes.Update(chuDe);
            dbContext.SaveChanges();
        }

        public List<BaiViet> LayDSBaiViet(string tieuDe = "")
        {
            if (tieuDe == "")
            {
                return dbContext.BaiViets.ToList();
            }
            else
            {
                List<BaiViet> lstbaiViet = dbContext.BaiViets.Where(x => x.TieuDe.ToLower().Contains(tieuDe.ToLower())).ToList();
                return lstbaiViet;
            }
        }

        public bool SuaBaiViet(BaiViet baiViet)
        {
            BaiViet baiVietCanSua = dbContext.BaiViets.SingleOrDefault(x => x.MaBaiViet == baiViet.MaBaiViet);
            ChuDe chuDe = dbContext.ChuDes.SingleOrDefault(x => x.MaChuDe == baiViet.MaChuDe);
            if (chuDe == null || baiVietCanSua == null)
            {
                return false;
            }
            else
            {
                // ma bai viet khong doi duoc
                baiVietCanSua.TieuDe = baiViet.TieuDe;
                baiVietCanSua.MoTa = baiViet.MoTa;
                baiVietCanSua.LinkAnh = baiViet.LinkAnh;
                baiVietCanSua.NoiDung = baiViet.NoiDung;
                baiVietCanSua.MaChuDe = baiViet.MaChuDe;
                baiVietCanSua.NgayCapNhat = DateTime.Now;
                baiVietCanSua.TenTacGia = baiViet.TenTacGia;
                baiVietCanSua.TaiKhoanNguoiDang = baiViet.TaiKhoanNguoiDang;
                dbContext.BaiViets.Update(baiVietCanSua);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool ThemBaiViet(BaiViet baiViet)
        {
            ChuDe chuDe = dbContext.ChuDes.SingleOrDefault(x => x.MaChuDe == baiViet.MaChuDe);
            if (chuDe == null)
            {
                return false;
            }
            else
            {
                dbContext.BaiViets.Add(baiViet);
                dbContext.SaveChanges();
                CapNhatSoLuongBaiViet(chuDe);
                return true;
            }
        }

        public bool XoaBaiViet(BaiViet baiViet)
        {
            BaiViet baiVietCanXoa = dbContext.BaiViets.SingleOrDefault(x => x.MaBaiViet == baiViet.MaBaiViet);
            ChuDe chuDe = dbContext.ChuDes.SingleOrDefault(x => x.MaChuDe == baiViet.MaChuDe);
            if (baiVietCanXoa == null)
            {
                return false;
            }
            else
            {
                dbContext.BaiViets.Remove(baiVietCanXoa);
                dbContext.SaveChanges();
                CapNhatSoLuongBaiViet(chuDe);
                return true;
            }
        }
    }
}
