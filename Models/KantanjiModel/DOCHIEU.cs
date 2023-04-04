namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCHIEU")]
    public partial class DOCHIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCHIEU()
        {
            DEDOCs = new HashSet<DEDOC>();
        }

        [Key]
        public int IDDH { get; set; }

        [Required]
        [StringLength(150)]
        public string LINKANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEDOC> DEDOCs { get; set; }
    }
}
