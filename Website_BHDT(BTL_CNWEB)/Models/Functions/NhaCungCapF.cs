using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website_BHDT_BTL_CNWEB_.Models.MD_Entities;

namespace Website_BHDT_BTL_CNWEB_.Models.Functions
{
    public class NhaCungCapF
    {
        DBContext_Entities context;
        public NhaCungCapF()
        {
            context = new DBContext_Entities();
        }

        /// <summary>
        /// Trả về list nhà cung cấp
        /// </summary>
        public IQueryable<NhaCungCap> NhaCungCaps
        {

            get { return context.NhaCungCaps; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Insert_NCC(NhaCungCap model)
        {
            NhaCungCap dbEntry = context.NhaCungCaps.Find(model.IDNCC);

            if (dbEntry != null)
            {
                return null;

            }
            context.NhaCungCaps.Add(model);

            context.SaveChanges();

            return model.IDNCC;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Update(NhaCungCap model)
        {
            NhaCungCap dbEntry = context.NhaCungCaps.Find(model.IDNCC);

            if (dbEntry == null)
            {
                return null;
            }
            dbEntry.TenNCC = model.TenNCC;
            dbEntry.DiaChi_NCC = model.DiaChi_NCC;
            dbEntry.SDT_NCC = model.SDT_NCC;
            context.SaveChanges();
            return model.IDNCC;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MaSP"></param>
        /// <returns></returns>
        public string Delete_NhaCungCap(string IDNCC)
        {
            NhaCungCap dbEntry = context.NhaCungCaps.Find(IDNCC);
            if (dbEntry == null)
            {
                return null;
            }
            context.NhaCungCaps.Remove(dbEntry);
            context.SaveChanges();
            return IDNCC;
        }






    }

}