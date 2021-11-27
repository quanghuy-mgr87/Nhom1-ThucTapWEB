using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;
using WebBongDaSo.IServices;

namespace WebBongDaSo.Services
{
    public class QuyenHan_LoaiNguoiDungServices : IQuyenHan_LoaiNguoiDungServices
    {
        private WebBongDaContext dbContext = new WebBongDaContext();

        public List<QuyenHan_LoaiNguoiDung> LayDSQuyenHan_LoaiNguoiDung()
        {
            return dbContext.QuyenHan_LoaiNguoiDungs.ToList();
        }

        public bool SuaQuyenHan_LoaiNguoiDung(QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung)
        {
            QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung1 = dbContext.QuyenHan_LoaiNguoiDungs.SingleOrDefault(x => x.Id == quyenHan_LoaiNguoiDung.Id);
            if(quyenHan_LoaiNguoiDung1 == null)
            {
                return false;
            }
            else
            {
                //id khong sua duoc
                quyenHan_LoaiNguoiDung1.QuyenHanId = quyenHan_LoaiNguoiDung.QuyenHanId;
                quyenHan_LoaiNguoiDung1.LoaiNguoiDungId = quyenHan_LoaiNguoiDung.LoaiNguoiDungId;
                dbContext.Update(quyenHan_LoaiNguoiDung1);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool ThemQuyenHan_LoaiNguoiDung(QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung)
        {
            QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung1 = dbContext.QuyenHan_LoaiNguoiDungs.SingleOrDefault(x => x.Id == quyenHan_LoaiNguoiDung.Id);
            if(quyenHan_LoaiNguoiDung1 != null)
            {
                return false;
            }
            else
            {
                dbContext.Add(quyenHan_LoaiNguoiDung);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool XoaQuyenHan_LoaiNguoiDung(int quyenHan_LoaiNguoiDungId)
        {
            QuyenHan_LoaiNguoiDung quyenHan_LoaiNguoiDung1 = dbContext.QuyenHan_LoaiNguoiDungs.SingleOrDefault(x => x.Id == quyenHan_LoaiNguoiDungId);
            if(quyenHan_LoaiNguoiDung1 == null)
            {
                return false;
            }
            else
            {
                dbContext.Remove(quyenHan_LoaiNguoiDung1);
                dbContext.SaveChanges();
                return true;
            }
        }
    }
}
