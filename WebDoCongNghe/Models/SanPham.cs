namespace WebDoCongNghe.Models
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
            DatHangs = new HashSet<DatHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        public int? Gia { get; set; }

        [StringLength(100)]
        public string image_link { get; set; }

        [StringLength(100)]
        public string image_list { get; set; }

        [StringLength(10)]
        public string MaDanhMuc { get; set; }

        [StringLength(100)]
        public string ManHinh { get; set; }

        [StringLength(40)]
        public string Ram { get; set; }

        [StringLength(20)]
        public string Pin { get; set; }

        [StringLength(50)]
        public string Camera { get; set; }

        [StringLength(50)]
        public string BoXuli { get; set; }

        [StringLength(40)]
        public string CamBien { get; set; }

        [StringLength(30)]
        public string TrongLuong { get; set; }

        [StringLength(30)]
        public string KhauDo { get; set; }

        public int? GiaSale { get; set; }

        public virtual DanhMucSp DanhMucSp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHang> DatHangs { get; set; }
    }
}
