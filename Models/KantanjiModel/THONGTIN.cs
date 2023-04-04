namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGTIN")]
    public partial class THONGTIN
    {
        [Key]
        public int IDTT { get; set; }

        [Required]
        [StringLength(255)]
        public string TEN { get; set; }

        public DateTime NGAYSINH { get; set; }

        [Required]
        [StringLength(100)]
        public string QUEQUAN { get; set; }

        [Column("CMND/CCCD")]
        [Required]
        [StringLength(12)]
        public string CMND_CCCD { get; set; }

        [Required]
        [StringLength(255)]
        public string ANH { get; set; }

        [Required]
        [StringLength(5)]
        public string CAPDO { get; set; }

        public int IDUSER { get; set; }

        public virtual USER USER { get; set; }
    }
}
