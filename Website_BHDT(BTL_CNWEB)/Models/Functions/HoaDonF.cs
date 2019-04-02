using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website_BHDT_BTL_CNWEB_.Models.MD_Entities;
namespace Website_BHDT_BTL_CNWEB_.Models.Functions
{
    public class HoaDonF
    {
        DBContext_Entities context;
        /// <summary>
        /// Trả về list Hóa Đơn
        /// </summary>
        public IQueryable<HoaDon> HoaDons
        {

            get { return context.HoaDons; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Insert_HoaDon(HoaDon model)
        {
            HoaDon dbEntry = context.HoaDons.Find(model.IDHoaDon);

            if (dbEntry != null)
            {
                return null;

            }
            context.HoaDons.Add(model);

            context.SaveChanges();

            return model.IDHoaDon;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Update(HoaDon model)
        {
            HoaDon dbEntry = context.HoaDons.Find(model.IDHoaDon);
          
            if (dbEntry == null)
            {
                return null;
            }
            dbEntry.NgayHD = model.NgayHD;
            dbEntry.IDKhachHang = model.IDKhachHang;
            dbEntry.IDNhanVien = model.IDNhanVien;
            dbEntry.TongTien = model.TongTien;
           
            context.SaveChanges();
            return model.IDHoaDon;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IDHoaDon"></param>
        /// <returns></returns>
        public string Delete_HoaDon(string IDHoaDon)
        {
            HoaDon dbEntry = context.HoaDons.Find(IDHoaDon);
            if (dbEntry == null)
            {
                return null;
            }
            context.HoaDons.Remove(dbEntry);
            context.SaveChanges();
            return IDHoaDon;
        }







    }
}