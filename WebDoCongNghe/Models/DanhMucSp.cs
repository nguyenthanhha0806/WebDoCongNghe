namespace WebDoCongNghe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucSp")]
    public partial class DanhMucSp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMucSp()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [StringLength(10)]
        public string MaDanhMuc { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(10)]
        public string MaDMCha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
