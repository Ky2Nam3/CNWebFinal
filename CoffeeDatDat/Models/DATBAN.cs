namespace CoffeeDatDat.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DATBAN")]
    public partial class DATBAN
    {
        [Key]
        public int MaBan { get; set; }

        public int? MaKH { get; set; }

        [StringLength(50)]
        public string TenBan { get; set; }

        [StringLength(20)]
        public string KhuVuc { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public int SoNguoi { get; set; }

        public bool? TrangThai { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
