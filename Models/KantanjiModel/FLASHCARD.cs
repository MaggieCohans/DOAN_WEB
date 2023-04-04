namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FLASHCARD")]
    public partial class FLASHCARD
    {
        [Key]
        public int IDFC { get; set; }

        [Required]
        [StringLength(100)]
        public string MATTRUOC { get; set; }

        [Required]
        [StringLength(100)]
        public string MATSAU { get; set; }

        public int IDCHUDE { get; set; }

        public virtual CHUDECHINH CHUDECHINH { get; set; }
    }
}
