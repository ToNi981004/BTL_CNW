using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website_BHDT_BTL_CNWEB_.Models.MD_Entities;
namespace Website_BHDT_BTL_CNWEB_.Models.Functions
{
    public class ChiTietHoaDonF
    {

        DBContext_Entities context;
        /// <summary>
        /// Trả về 1 list Chi Tiết Hóa Đơn
        /// </summary>
        public IQueryable<ChiTietHoaDon> ChiTietHoaDons
        {

            get { return context.ChiTietHoaDons; }
        }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public string Insert_ChiTietHD(ChiTietHoaDon model)
    {
        ChiTietHoaDon dbEntry = context.ChiTietHoaDons.Find(model.IDHoaDon);

        if (dbEntry != null)
        {
            return null;

        }
        context.ChiTietHoaDons.Add(model);

        context.SaveChanges();

        return model.IDHoaDon;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public string Update(ChiTietHoaDon model)
    {
        ChiTietHoaDon dbEntry = context.ChiTietHoaDons.Find(model.IDHoaDon);
        if (dbEntry == null)
        {
            return null;
        }
            dbEntry.IDSanPham = model.IDSanPham;
            dbEntry.DonGiaBan = model.DonGiaBan;
            dbEntry.SoLuong = model.SoLuong;
            dbEntry.TGBaoHanh = model.TGBaoHanh;
        context.SaveChanges();
        return model.IDHoaDon;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="IDHoaDon"></param>
    /// <returns></returns>
    public string Delete_ChiTietHoaDon(string IDHoaDon)
    {
        ChiTietHoaDon dbEntry = context.ChiTietHoaDons.Find(IDHoaDon);
        if (dbEntry == null)
        {
            return null;
        }
        context.ChiTietHoaDons.Remove(dbEntry);
        context.SaveChanges();
        return IDHoaDon;
    }



}
}