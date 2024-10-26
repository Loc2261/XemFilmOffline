namespace XemPhimOffline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRating")]
    public partial class UserRating
    {
        [Key]
        public int RatingID { get; set; }

        public int MaTaiKhoan { get; set; }

        public int MaPhim { get; set; }

        public decimal Rating { get; set; }

        public string Review { get; set; }

        public DateTime? RatingDate { get; set; }

        public virtual Account Account { get; set; }

        public virtual Phim Phim { get; set; }
    }
}
