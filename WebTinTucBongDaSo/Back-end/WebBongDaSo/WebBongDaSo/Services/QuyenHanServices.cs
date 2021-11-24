using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;
using WebBongDaSo.IServices;

namespace WebBongDaSo.Services
{
    public class QuyenHanServices : IQuyenHanServices
    {
        private WebBongDaContext dbContext = new WebBongDaContext();
        public List<QuyenHan> LayDSQuyenHan()
        {
            return dbContext.QuyenHans.ToList();
        }

        public bool SuaQuyenHan(QuyenHan quyenHan)
        {
            QuyenHan quyenHanCanSua = dbContext.QuyenHans.SingleOrDefault(x => x.QuyenHanId == quyenHan.QuyenHanId);
            if(quyenHanCanSua == null) //khong co khong sua duoc
            {
                return false;
            }
            else
            {
                //quyenhanid khong duoc sua
                quyenHanCanSua.TenQuyenHan = quyenHan.TenQuyenHan;
                dbContext.Update(quyenHanCanSua);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool ThemQuyenHan(QuyenHan quyenHan)
        {
            QuyenHan quyenHanCanThem = dbContext.QuyenHans.SingleOrDefault(x => x.QuyenHanId == quyenHan.QuyenHanId);
            if(quyenHanCanThem != null) //co roi thi ko them duoc
            {
                return false;
            }
            else
            {
                dbContext.Add(quyenHanCanThem);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool XoaQuyenHan(int quyenHanId)
        {
            QuyenHan quyenHanCanXoa = dbContext.QuyenHans.SingleOrDefault(x => x.QuyenHanId == quyenHanId);
            if(quyenHanCanXoa == null)
            {
                return false;
            }
            else
            {
                dbContext.Remove(quyenHanCanXoa);
                dbContext.SaveChanges();
                return true;
            }
        }
    }
}
