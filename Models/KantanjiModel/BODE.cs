namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BODE")]
    public partial class BODE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BODE()
        {
            DEDOCs = new HashSet<DEDOC>();
            DENGHEs = new HashSet<DENGHE>();
            DETVNPs = new HashSet<DETVNP>();
        }

        [Key]
        public int IDBODE { get; set; }

        [Required]
        [StringLength(150)]
        public string TENBODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEDOC> DEDOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DENGHE> DENGHEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETVNP> DETVNPs { get; set; }
    }
}
