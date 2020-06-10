namespace CoffeeDatDat.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UngTuyen")]
    public partial class UngTuyen
    {
        [Key]
        public int MaUT { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(15)]
        public string SĐT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string ViTri { get; set; }
    }
}
