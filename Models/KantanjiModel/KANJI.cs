namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Collections;

    [Table("KANJI")]
    public partial class KANJI
    {
        [Key]
        public int IDKANJI { get; set; }

        [Required]
        [StringLength(10)]
        public string TUKANJI { get; set; }

        [Required]
        [StringLength(150)]
        public string ANHKANJI { get; set; }

        [Required]
        [StringLength(150)]
        public string HANVIET { get; set; }

        [Required]
        [StringLength(150)]
        public string NGHIA { get; set; }

        [Required]
        [StringLength(50)]
        public string AMON { get; set; }

        [Required]
        [StringLength(50)]
        public string AMKUN { get; set; }

        [Required]
        [StringLength(255)]
        public string VIDU { get; set; }

        public int IDNGUCANH { get; set; }

        public virtual NGUCANH NGUCANH { get; set; }
    }


}

