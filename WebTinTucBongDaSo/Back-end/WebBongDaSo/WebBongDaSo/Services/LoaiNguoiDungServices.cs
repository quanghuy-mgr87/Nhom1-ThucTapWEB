using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;
using WebBongDaSo.IServices;

namespace WebBongDaSo.Services
{
    public class LoaiNguoiDungServices : ILoaiNguoiDungServices
    {
        private WebBongDaContext dbContext = new WebBongDaContext();

        public List<LoaiNguoiDung> LayDSLoaiNguoiDung()
        {
            return dbContext.LoaiNguoiDungs.ToList();
        }

        public bool SuaLoaiNguoiDung(LoaiNguoiDung loaiNguoiDung)
        {
            LoaiNguoiDung loaiNguoiDungCanSua = dbContext.LoaiNguoiDungs.SingleOrDefault(x => x.LoaiNguoiDungId == loaiNguoiDung.LoaiNguoiDungId);
            if (loaiNguoiDungCanSua == null) // khong co khong sua duoc
            {
                return false;
            }
            else
            {
                //loainguoidungid khong sua duoc
                loaiNguoiDungCanSua.TenLoai = loaiNguoiDung.TenLoai;
                dbContext.Update(loaiNguoiDungCanSua);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool ThemLoaiNguoiDung(LoaiNguoiDung loaiNguoiDung)
        {
            LoaiNguoiDung loaiNguoiDungCanThem = dbContext.LoaiNguoiDungs.SingleOrDefault(x => x.MaLoai.ToLower() == loaiNguoiDung.MaLoai.ToLower());
            if (loaiNguoiDungCanThem != null)
            {
                return false;
            }
            else
            {
                loaiNguoiDung.MaLoai = loaiNguoiDung.MaLoai.ToUpper();
                dbContext.Add(loaiNguoiDung);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool XoaLoaiNguoiDung(int loaiNguoiDungId)
        {
            LoaiNguoiDung loaiNguoiDungCanXoa = dbContext.LoaiNguoiDungs.SingleOrDefault(x => x.LoaiNguoiDungId == loaiNguoiDungId);
            List<NguoiDung> lstNguoiDung = dbContext.NguoiDungs.Where(x => x.LoaiNguoiDungId == loaiNguoiDungId).ToList();
            // xoa ca bai viet
            if (loaiNguoiDungCanXoa == null) // ko ton tai ko xoa duoc
            {
                return false;
            }
            else if (lstNguoiDung.Count > 0) //neu co nguoi dung thuoc loai nguoi dung do thi xoa luon
            {
                dbContext.RemoveRange(lstNguoiDung);
                dbContext.SaveChanges();
            }
            dbContext.Remove(loaiNguoiDungCanXoa);
            dbContext.SaveChanges();
            return true;
        }
    }
}
