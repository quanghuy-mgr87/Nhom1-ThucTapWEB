using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Entities;
using WebBongDaSo.IServices;

namespace WebBongDaSo.Services
{
    public class ChuDeServices : IChuDeServices
    {
        private WebBongDaContext dbContext = new WebBongDaContext();
        public List<ChuDe> LayDSChuDe(string tenChuDe = "")
        {
            if(tenChuDe == "")
            {
                return dbContext.ChuDes.ToList(); // lay danh sach tat ca chu de
            }
            else
            {
                List<ChuDe> lstChuDe = dbContext.ChuDes.Where(x => x.TenChuDe.ToLower().Contains(tenChuDe.ToLower())).ToList(); // lay danh sach cac chu de chua cai ten chu de do
                return lstChuDe;
            }
        }

        public bool SuaChuDe(ChuDe chuDe)
        {
            ChuDe chuDeCanSua = dbContext.ChuDes.SingleOrDefault(x => x.MaChuDe == chuDe.MaChuDe);
            if(chuDeCanSua == null) // neu khong co chu de can sua
            {
                return false;
            }
            else
            {
                // ma chu de khong sua duoc
                chuDeCanSua.TenChuDe = chuDe.TenChuDe;
                chuDeCanSua.SoLuongBaiViet = chuDe.SoLuongBaiViet;
                dbContext.Update(chuDeCanSua);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool ThemChuDe(ChuDe chuDe)
        {
            ChuDe chuDeCanThem = dbContext.ChuDes.SingleOrDefault(x => x.TenChuDe.ToLower() == chuDe.TenChuDe.ToLower()); // tim thang chu de giong voi chu de dinh them
            if(chuDeCanThem != null) //neu thang chuDeCanThem ton tai thi tuc la da co chu de day roi
            {
                return false;
            }
            else
            {
                dbContext.ChuDes.Add(chuDe);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool XoaChuDe(int maChuDe)
        {
            ChuDe chuDe = dbContext.ChuDes.SingleOrDefault(x => x.MaChuDe == maChuDe); //tim nhung tk co ma chu de giong voi ma chu de da nhap vao
            List<BaiViet> lstbaiViet = dbContext.BaiViets.Where(x => x.MaChuDe == maChuDe).ToList();//tim nhung tk bai viet co ma chu de giong voi ma chu de do
            if(chuDe == null) //neu ko ton tai thi ko xoa dc
            {
                return false;
            }
            else if (lstbaiViet.Count > 0) //chu de co ton tai, thi xoa het bai viet
            {
                dbContext.Remove(lstbaiViet);
                dbContext.SaveChanges();
            }
            dbContext.Remove(chuDe); // xoa chu de
            dbContext.SaveChanges();
            return true;
        }
    }
}
