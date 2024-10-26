namespace XemPhimOffline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phim")]
    public partial class Phim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phim()
        {
            Playlists = new HashSet<Playlist>();
            UserRatings = new HashSet<UserRating>();
            WatchHistories = new HashSet<WatchHistory>();
            GoiPhims = new HashSet<GoiPhim>();
            DaoDiens = new HashSet<DaoDien>();
            DienViens = new HashSet<DienVien>();
            TheLoais = new HashSet<TheLoai>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhim { get; set; }

        [StringLength(200)]
        public string TenPhim { get; set; }

        public DateTime? NgaySanXuat { get; set; }

        public string NoiDungPhim { get; set; }

        public double? DiemDanhGia { get; set; }

        public TimeSpan? ThoiLuong { get; set; }

        public int MaQuocGia { get; set; }

        public int MaNgonNgu { get; set; }

        [StringLength(255)]
        public string BannerUrl { get; set; }

        [StringLength(255)]
        public string MovieFilePath { get; set; }

        public virtual NgonNgu NgonNgu { get; set; }

        public virtual QuocGia QuocGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Playlist> Playlists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRating> UserRatings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WatchHistory> WatchHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoiPhim> GoiPhims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaoDien> DaoDiens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DienVien> DienViens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheLoai> TheLoais { get; set; }
    }
}
