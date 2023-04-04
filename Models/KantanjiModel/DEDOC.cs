namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEDOC")]
    public partial class DEDOC
    {
        [Key]
        public int IDDOC { get; set; }

        public int IDBODE { get; set; }

        public int IDDH { get; set; }

        [Required]
        [StringLength(255)]
        public string CAUHOI { get; set; }

        [Required]
        [StringLength(255)]
        public string DA1 { get; set; }

        [Required]
        [StringLength(255)]
        public string DA2 { get; set; }

        [Required]
        [StringLength(255)]
        public string DA3 { get; set; }

        public virtual BODE BODE { get; set; }

        public virtual DOCHIEU DOCHIEU { get; set; }
    }
}
