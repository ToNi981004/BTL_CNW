namespace Website_BHDT_BTL_CNWEB_.Models.MD_Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string IDKhachHang { get; set; }

        [StringLength(20)]
        public string Ho { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }

        [StringLength(3)]
        public string GioiTinh_KH { get; set; }

        [StringLength(50)]
        public string TenCongTy { get; set; }

        [StringLength(10)]
        public string SDT_KH { get; set; }

        [StringLength(200)]
        public string DiaChi_KH { get; set; }

        [StringLength(50)]
        public string ThanhPho { get; set; }

        [StringLength(30)]
        public string Quan { get; set; }

        [StringLength(10)]
        public string MaBuuDien { get; set; }

        [StringLength(100)]
        public string DiaChiEmail { get; set; }

        public double? TongTienMua { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
