namespace WebDoCongNghe.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDB : DbContext
    {
        public MyDB()
            : base("name=MyDB1")
        {
        }

        public virtual DbSet<DanhMucSp> DanhMucSps { get; set; }
        public virtual DbSet<DatHang> DatHangs { get; set; }
        public virtual DbSet<GiaoDich> GiaoDiches { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMucSp>()
                .Property(e => e.MaDanhMuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucSp>()
                .Property(e => e.MaDMCha)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DatHang>()
                .Property(e => e.MaDatHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DatHang>()
                .Property(e => e.MaGD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DatHang>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiaoDich>()
                .Property(e => e.MaGD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiaoDich>()
                .Property(e => e.MaNguoiDung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MaNguoiDung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaDanhMuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Pin)
                .IsUnicode(false);
        }
    }
}
