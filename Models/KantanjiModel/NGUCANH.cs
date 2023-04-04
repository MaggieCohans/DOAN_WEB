namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUCANH")]
    public partial class NGUCANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUCANH()
        {
            KANJIs = new HashSet<KANJI>();
        }

        [Key]
        public int IDNGUCANH { get; set; }

        [Required]
        [StringLength(150)]
        public string TENNGUCANH { get; set; }

        [Required]
        [StringLength(150)]
        public string LINKANH { get; set; }

        public int IDCHUDE { get; set; }

        public int IDCAPDO { get; set; }

        public virtual CAPDO CAPDO { get; set; }

        public virtual CHUDECHINH CHUDECHINH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KANJI> KANJIs { get; set; }
    }
}
