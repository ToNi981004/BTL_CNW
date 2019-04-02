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



//======================================================================\\



        /// <summary>
        /// Trả về 1 list Sản Phẩm
        /// </summary>
        public IQueryable<SanPham> SanPhams
        {
            
            get { return context.SanPhams; }
        }
        /// <summary>
        /// Hàm thêm một sản phẩm mới
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Insert_SanPham(SanPham model)
        {
            SanPham dbEntry = context.SanPhams.Find(model.IDSanPham);

            if (dbEntry != null)
            {
                return null;

            }
            context.SanPhams.Add(model);

            context.SaveChanges();

            return model.IDSanPham;
        }
        /// <summary>
        /// Sửa một sản phẩm
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Update(SanPham model)
        {
            SanPham dbEntry = context.SanPhams.Find(model.IDSanPham);
           
            if (dbEntry == null)
            {
                return null;
            }
            dbEntry.TenSanPham = model.TenSanPham;
            dbEntry.DVT = model.DVT;
            dbEntry.SoLuongTon = model.SoLuongTon;
            dbEntry.Anh = model.Anh;
            dbEntry.DonGiaN = model.DonGiaN;
            dbEntry.DonGiaB = model.DonGiaB;
            dbEntry.TGBaoHanh = model.TGBaoHanh;
            dbEntry.IDNCC = model.IDNCC;
            dbEntry.Hang = model.Hang;
            dbEntry.XuatXu = model.XuatXu;
            dbEntry.MaHinh = model.MaHinh;
            dbEntry.HeDieuHanh = model.HeDieuHanh;
            dbEntry.CameraSau = model.CameraSau;
            dbEntry.CameraTruoc = model.CameraTruoc;
            dbEntry.CPU = model.CPU;
            dbEntry.RAM = model.RAM;
            dbEntry.BoNhoTrong = model.BoNhoTrong;
            dbEntry.TheSim = model.TheSim;
            dbEntry.DungLuongPin = model.DungLuongPin;
            dbEntry.ThietKe = model.ThietKe;
            dbEntry.TinhTrang = model.TinhTrang;
            dbEntry.MoTaSanPham = model.MoTaSanPham;
            
            context.SaveChanges();
            return model.IDSanPham;
        }
        /// <summary>
        /// Xóa Một Sản Phẩm
        /// </summary>
        /// <param name="MaSP"></param>
        /// <returns></returns>
        public string Delete_SanPham(string MaSP)
        {
            SanPham dbEntry = context.SanPhams.Find(MaSP);
            if (dbEntry == null)
            {
                return null;
            }
            context.SanPhams.Remove(dbEntry);
            context.SaveChanges();
            return MaSP;
        }

// Hàm trả về một đối tượng khi biết khóa
public SanPham FindEntity(string MaSP)
        {
            SanPham dbEntry = context.SanPhams.Find(MaSP);
            return dbEntry;
        }
        // Hàm trả về 1 list Sản Phẩm có điều kiện là mã Hóa Đơn Là HD01
        public List<SanPham>DSSP_KH()
        {
            var ProductList = context.SanPhams.SqlQuery("Select sp.IDSanPham,TenSanPham,DVT,SoLuongTon,Anh,DonGiaN,DonGiaB,sp.TGBaoHanh,IDNCC,Hang,XuatXu,MaHinh,HeDieuHanh,CameraSau,CameraTruoc,CPU,RAM,BoNhoTrong,TheSim,DungLuongPin,ThietKe,TinhTrang,MoTaSanPham from SanPham sp,ChiTietHoaDon hd where sp.IDSanPham=hd.IDSanPham AND IDHoaDon='HD01'").ToList<SanPham>();
            return ProductList;
        }
        // Xóa một sản phẩm vào giỏ hàng
        public string Delete(string MaSP)
        {
            ChiTietHoaDon dbEntry = context.ChiTietHoaDons.Find("HD01",MaSP);
            if (dbEntry == null)
            {
                return null;
            }
            context.ChiTietHoaDons.Remove(dbEntry);
            context.SaveChanges();
            return MaSP;
        }

    }
}