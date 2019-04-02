using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website_BHDT_BTL_CNWEB_.Models.MD_Entities;

namespace Website_BHDT_BTL_CNWEB_.Models.Functions
{
    public class SanPhamF
    {
        private DBContext_Entities context;
        public SanPhamF()
        {
            context = new DBContext_Entities();
        }
        public IQueryable<SanPham> SanPhams
        {
            
            get { return context.SanPhams; }
        }
       
        public SanPham FindEntity(string MaSP)
        {
            SanPham dbEntry = context.SanPhams.Find(MaSP);
            return dbEntry;
        }
        public List<SanPham>DSSP_KH()
        {
            var ProductList = context.SanPhams.SqlQuery("Select sp.IDSanPham,TenSanPham,DVT,SoLuongTon,Anh,DonGiaN,DonGiaB,sp.TGBaoHanh,IDNCC,Hang,XuatXu,MaHinh,HeDieuHanh,CameraSau,CameraTruoc,CPU,RAM,BoNhoTrong,TheSim,DungLuongPin,ThietKe,TinhTrang,MoTaSanPham from SanPham sp,ChiTietHoaDon hd where sp.IDSanPham=hd.IDSanPham AND IDHoaDon='HD01'").ToList<SanPham>();
            return ProductList;
        }

    }
}