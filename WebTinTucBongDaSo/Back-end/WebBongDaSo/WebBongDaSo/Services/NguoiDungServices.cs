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
        private LoaiNguoiDungServices loaiNguoiDungServices = new LoaiNguoiDungServices();

        public bool KiemTraDangNhap(NguoiDung nguoiDung)
        {
            //Kiểm tra xem có tồn tại bất kỳ người dùng nào trong bảng người dùng có tài khoản và mật khẩu giống tài khoản, mật khẩu của người dùng truyền vào không
            return dbContext.NguoiDungs.Any(x => x.TaiKhoan == nguoiDung.TaiKhoan && x.MatKhau == nguoiDung.MatKhau);
        }

        public List<NguoiDung> LayDSNguoiDung()
        {
            return dbContext.NguoiDungs.ToList();
        }

        public string LayMaLoaiNguoiDung(NguoiDung nguoiDung)
        {
            LoaiNguoiDung loaiNguoiDung = loaiNguoiDungServices.LayLoaiNguoiDungTheoMa(nguoiDung.LoaiNguoiDungId);
            if (loaiNguoiDung != null)
            {
                return loaiNguoiDung.MaLoai;
            }
            return "";
        }

        public NguoiDung LayNguoiDungTheoTaiKhoan(string taiKhoan)
        {
            return dbContext.NguoiDungs.SingleOrDefault(x => x.TaiKhoan == taiKhoan);
        }

        public bool SuaNguoiDung(NguoiDung nguoiDung)
        {
            NguoiDung nguoiDungCanSua = dbContext.NguoiDungs.SingleOrDefault(x => x.TaiKhoan == nguoiDung.TaiKhoan);
            if (nguoiDungCanSua == null) // co thi moi sua duoc
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
                //Người dùng mới thêm vào mặc định là độc giả
                int loaiNguoiDungId = dbContext.LoaiNguoiDungs.SingleOrDefault(x => x.MaLoai == "DG").LoaiNguoiDungId;
                nguoiDung.LoaiNguoiDungId = loaiNguoiDungId;
                //update thời gian tham gia là thời gian hiện tại
                nguoiDung.ThoiGianThamGia = DateTime.Now;
                dbContext.Add(nguoiDung);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool XoaNguoiDung(string taiKhoan)
        {
            NguoiDung nguoiDungCanXoa = dbContext.NguoiDungs.SingleOrDefault(x => x.TaiKhoan == taiKhoan);
            List<BaiViet> lstBaiViet = dbContext.BaiViets.Where(x => x.TaiKhoanNguoiDang == taiKhoan).ToList();
            if (nguoiDungCanXoa == null)
            {
                return false; // khong co khong cho xoa duoc
            }
            else if (lstBaiViet.Count > 0) // xoa tat ca thang bai viet cua nguoi dung do
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
