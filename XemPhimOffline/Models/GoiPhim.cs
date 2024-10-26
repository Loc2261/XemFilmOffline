namespace XemPhimOffline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoiPhim")]
    public partial class GoiPhim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoiPhim()
        {
            Phims = new HashSet<Phim>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGoiPhim { get; set; }

        public int MaTaiKhoan { get; set; }

        public DateTime? NgayMua { get; set; }

        public DateTime? NgayHetHan { get; set; }

        public decimal? ChiPhiGoi { get; set; }

        public int? LoaiGoi { get; set; }

        [StringLength(100)]
        public string TenGoi { get; set; }

        public string NoiDungGoi { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phim> Phims { get; set; }
    }
}
