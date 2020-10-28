namespace WebDoCongNghe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoDich")]
    public partial class GiaoDich
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoDich()
        {
            DatHangs = new HashSet<DatHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaGD { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        [StringLength(20)]
        public string CongThanhToan { get; set; }

        public int? TongSoTien { get; set; }

        public DateTime? ThoiGian { get; set; }

        [StringLength(10)]
        public string MaNguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHang> DatHangs { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
