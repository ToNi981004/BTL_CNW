using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website_BHDT_BTL_CNWEB_.Models.MD_Entities;
namespace Website_BHDT_BTL_CNWEB_.Models.Functions
{
    public class NhanVienF
    {
        DBContext_Entities context;
        public NhanVienF()
        {
            context = new DBContext_Entities();
        }

        /// <summary>
        /// Trả về list nhà cung cấp
        /// </summary>
        public IQueryable<NhanVien> NhanViens
        {

            get { return context.NhanViens; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Insert_NCC(NhanVien model)
        {
            NhanVien dbEntry = context.NhanViens.Find(model.IDNhanVien);

            if (dbEntry != null)
            {
                return null;

            }
            context.NhanViens.Add(model);

            context.SaveChanges();

            return model.IDNhanVien;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Update(NhanVien model)
        {
            NhanVien dbEntry = context.NhanViens.Find(model.IDNhanVien);

            if (dbEntry == null)
            {
                return null;
            }
            dbEntry.TenNhanVien = model.TenNhanVien;
            dbEntry.GioiTinh_NV = model.GioiTinh_NV;
            dbEntry.ChucVu = model.ChucVu;
            dbEntry.SDT_NV = model.SDT_NV;
            context.SaveChanges();
            return model.IDNhanVien;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MaSP"></param>
        /// <returns></returns>
        public string Delete_NhanVien(string IDNhanVien)
        {
            NhanVien dbEntry = context.NhanViens.Find(IDNhanVien);
            if (dbEntry == null)
            {
                return null;
            }
            context.NhanViens.Remove(dbEntry);
            context.SaveChanges();
            return IDNhanVien;
        }
    }
       
}