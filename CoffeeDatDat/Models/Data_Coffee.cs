namespace CoffeeDatDat.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Data_Coffee : DbContext
    {
        public Data_Coffee()
            : base("name=Data_Coffee")
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual DbSet<DATBAN> DATBANs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiMon> LoaiMons { get; set; }
        public virtual DbSet<Mon> Mons { get; set; }
        public virtual DbSet<NguyenLieu> NguyenLieux { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UngTuyen> UngTuyens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mon>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.Mon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguyenLieu>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.NguyenLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.PhieuNhap)
                .WillCascadeOnDelete(false);
        }
    }
}
