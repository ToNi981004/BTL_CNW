namespace Website_BHDT_BTL_CNWEB_.Models.MD_Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string IDSanPham { get; set; }

        [StringLength(50)]
        public string TenSanPham { get; set; }

        [StringLength(20)]
        public string DVT { get; set; }

        public int? SoLuongTon { get; set; }

        public string Anh { get; set; }

        public double? DonGiaN { get; set; }

        public double? DonGiaB { get; set; }

        [StringLength(20)]
        public string TGBaoHanh { get; set; }

        [StringLength(10)]
        public string IDNCC { get; set; }

        [StringLength(30)]
        public string Hang { get; set; }

        [StringLength(20)]
        public string XuatXu { get; set; }

        [StringLength(30)]
        public string MaHinh { get; set; }

        [StringLength(50)]
        public string HeDieuHanh { get; set; }

        [StringLength(200)]
        public string CameraSau { get; set; }

        [StringLength(200)]
        public string CameraTruoc { get; set; }

        [StringLength(50)]
        public string CPU { get; set; }

        [StringLength(10)]
        public string RAM { get; set; }

        [StringLength(10)]
        public string BoNhoTrong { get; set; }

        [StringLength(50)]
        public string TheSim { get; set; }

        [StringLength(20)]
        public string DungLuongPin { get; set; }

        [StringLength(50)]
        public string ThietKe { get; set; }

        public double? TinhTrang { get; set; }

        public string MoTaSanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
