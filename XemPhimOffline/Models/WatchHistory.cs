namespace XemPhimOffline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WatchHistory")]
    public partial class WatchHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTaiKhoan { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhim { get; set; }

        public DateTime? LastWatched { get; set; }

        public TimeSpan? WatchDuration { get; set; }

        public virtual Account Account { get; set; }

        public virtual Phim Phim { get; set; }
    }
}
