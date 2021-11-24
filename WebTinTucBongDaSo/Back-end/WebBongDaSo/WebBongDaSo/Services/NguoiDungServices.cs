using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;
using WebBongDaSo.IServices;

namespace WebBongDaSo.Services
{
    public class NguoiDungServices : INguoiDungServices
    {
        private WebBongDaContext dbContext = new WebBongDaContext();
        public List<NguoiDung> LayDSNguoiDung()
        {
            throw new NotImplementedException();
        }

        public bool SuaNguoiDung(NguoiDung nguoiDung)
        {
            NguoiDung nguoiDungCanSua = dbContext.NguoiDungs.SingleOrDefault(x => x.TaiKhoan == nguoiDung.TaiKhoan);
            if(nguoiDungCanSua == null) // co thi moi sua duoc
            {
                return false;
            }
            else
            {
                //khong duoc sua tai khoan
                nguoiDungCanSua.MatKhau = nguoiDung.MatKhau;
                nguoiDungCanSua.HoTen = nguoiDung.HoTen;
                nguoiDungCanSua.GioiTinh = nguoiDung.GioiTinh;
                nguoiDung.DiaChi = nguoiDung.DiaChi;
                //khong duoc sua thoi gian tham gia
                nguoiDung.LoaiNguoiDungId = nguoiDung.LoaiNguoiDungId;
                dbContext.Update(nguoiDungCanSua);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool ThemNguoiDung(NguoiDung nguoiDung)
        {
            NguoiDung nguoiDungCanThem = dbContext.NguoiDungs.SingleOrDefault(x => x.TaiKhoan == nguoiDung.TaiKhoan);
            if (nguoiDungCanThem != null)
            {
                return false;
            }
            else
            {
                dbContext.Add(nguoiDungCanThem);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool XoaNguoiDung(string taiKhoan)
        {
            NguoiDung nguoiDungCanXoa = dbContext.NguoiDungs.SingleOrDefault(x => x.TaiKhoan == taiKhoan);
            List<BaiViet> lstBaiViet = dbContext.BaiViets.Where(x => x.TaiKhoanNguoiDang == taiKhoan).ToList();
            if(nguoiDungCanXoa == null)
            {
                return false; // khong co khong cho xoa duoc
            }
            else if(lstBaiViet.Count > 0) // xoa tat ca thang bai viet cua nguoi dung do
            {
                dbContext.RemoveRange(lstBaiViet);
                dbContext.SaveChanges();
            }
            dbContext.Remove(nguoiDungCanXoa);
            dbContext.SaveChanges();
            return true;
        }
    }
}
