namespace WebDoCongNghe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatHang")]
    public partial class DatHang
    {
        [Key]
        [StringLength(10)]
        public string MaDatHang { get; set; }

        public int? SoLuong { get; set; }

        public int? SoTien { get; set; }

        [StringLength(10)]
        public string MaGD { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        public virtual GiaoDich GiaoDich { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
