namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUDECHINH")]
    public partial class CHUDECHINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUDECHINH()
        {
            FLASHCARDs = new HashSet<FLASHCARD>();
            NGUCANHs = new HashSet<NGUCANH>();
        }

        [Key]
        public int IDCHUDE { get; set; }

        [Required]
        [StringLength(255)]
        public string TENCHUDE { get; set; }

        [Required]
        [StringLength(150)]
        public string LINKANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLASHCARD> FLASHCARDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUCANH> NGUCANHs { get; set; }
    }
}
