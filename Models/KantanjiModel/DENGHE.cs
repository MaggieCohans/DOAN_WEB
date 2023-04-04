namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DENGHE")]
    public partial class DENGHE
    {
        [Key]
        public int IDNGHE { get; set; }

        public int IDAUDIO { get; set; }

        public int IDBODE { get; set; }

        [Required]
        [StringLength(255)]
        public string DA1 { get; set; }

        [Required]
        [StringLength(255)]
        public string DA2 { get; set; }

        [Required]
        [StringLength(255)]
        public string DA3 { get; set; }

        public virtual AUDIO AUDIO { get; set; }

        public virtual BODE BODE { get; set; }
    }
}
