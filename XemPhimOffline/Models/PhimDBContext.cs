using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using static XemPhimOffline.GUI.frmLanguage;

namespace XemPhimOffline.Models
{
    public partial class PhimDBContext : DbContext
    {
        public PhimDBContext()
            : base("name=PhimDBContext1")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<DaoDien> DaoDiens { get; set; }
        public virtual DbSet<DienVien> DienViens { get; set; }
        public virtual DbSet<GoiPhim> GoiPhims { get; set; }
        public virtual DbSet<NgonNgu> NgonNgus { get; set; }
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<QuocGia> QuocGias { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<UserRating> UserRatings { get; set; }
        public virtual DbSet<WatchHistory> WatchHistories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<DaoDien>()
                .HasMany(e => e.Phims)
                .WithMany(e => e.DaoDiens)
                .Map(m => m.ToTable("DaoDienPhim").MapLeftKey("MaDaoDien").MapRightKey("MaPhim"));

            modelBuilder.Entity<DienVien>()
                .HasMany(e => e.Phims)
                .WithMany(e => e.DienViens)
                .Map(m => m.ToTable("DienVienPhim").MapLeftKey("MaDienVien").MapRightKey("MaPhim"));

            modelBuilder.Entity<GoiPhim>()
                .HasMany(e => e.Phims)
                .WithMany(e => e.GoiPhims)
                .Map(m => m.ToTable("ChiTietGoiPhim").MapLeftKey("MaGoiPhim").MapRightKey("MaPhim"));

            modelBuilder.Entity<Phim>()
                .Property(e => e.BannerUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Phim>()
                .Property(e => e.MovieFilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Phim>()
                .HasMany(e => e.TheLoais)
                .WithMany(e => e.Phims)
                .Map(m => m.ToTable("TheLoaiPhim").MapLeftKey("MaPhim").MapRightKey("MaTheLoai"));

            modelBuilder.Entity<UserRating>()
                .Property(e => e.Rating)
                .HasPrecision(2, 1);
        }
    }
}
