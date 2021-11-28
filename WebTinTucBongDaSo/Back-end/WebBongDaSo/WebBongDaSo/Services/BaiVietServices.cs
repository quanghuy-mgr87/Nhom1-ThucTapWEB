using Microsoft.EntityFrameworkCore;
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

        public List<BaiViet> LayDSBaiViet(string tieuDe = "", string taiKhoan = "", int maChuDe = 0)
        {
            var lstbaiViet = dbContext.BaiViets.ToList();
            if (maChuDe != 0)   //Nếu mã chủ đề khác 0 thì lấy danh sách theo mã chủ đề
            {
                lstbaiViet = lstbaiViet.Where(x => x.MaChuDe == maChuDe).ToList();
            }
            if (!string.IsNullOrEmpty(tieuDe))   //Nếu tiêu đề không rỗng
            {
                //Lấy danh sách bài viết theo tiêu đề
                lstbaiViet = lstbaiViet.Where(x => x.TieuDe.ToLower().Contains(tieuDe.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(taiKhoan))    //Nếu tài khoản không rỗng
            {
                //Lấy danh sách bài viết theo tài khoản
                lstbaiViet = lstbaiViet.Where(x => x.TaiKhoanNguoiDang == taiKhoan).ToList();
            }
            return lstbaiViet;
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
                baiViet.NgayTao = DateTime.Now;
                baiViet.NgayCapNhat = DateTime.Now;
                dbContext.BaiViets.Add(baiViet);
                dbContext.SaveChanges();
                CapNhatSoLuongBaiViet(chuDe);
                return true;
            }
        }

        public BaiViet TimBaiVietMoiNhat()
        {
            if (dbContext.BaiViets.ToList().Count == 0)
                return null;
            return dbContext.BaiViets.OrderBy(x => x.MaBaiViet).Last();
        }

        public BaiViet TimBaiVietTheoMa(int baiVietId)
        {
            BaiViet baiViet = dbContext.BaiViets.SingleOrDefault(x => x.MaBaiViet == baiVietId);
            return baiViet;
        }

        public bool XoaBaiViet(int maBaiViet)
        {
            BaiViet baiVietCanXoa = dbContext.BaiViets.SingleOrDefault(x => x.MaBaiViet == maBaiViet);
            if (baiVietCanXoa == null)
            {
                return false;
            }
            else
            {
                ChuDe chuDe = dbContext.ChuDes.SingleOrDefault(x => x.MaChuDe == baiVietCanXoa.MaChuDe);
                dbContext.BaiViets.Remove(baiVietCanXoa);
                dbContext.SaveChanges();
                CapNhatSoLuongBaiViet(chuDe);
                return true;
            }
        }
    }
}
