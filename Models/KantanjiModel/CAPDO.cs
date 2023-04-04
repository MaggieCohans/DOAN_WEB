namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAPDO")]
    public partial class CAPDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAPDO()
        {
            NGUCANHs = new HashSet<NGUCANH>();
        }

        [Key]
        public int IDCAPDO { get; set; }

        [Required]
        [StringLength(150)]
        public string TENCAPDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUCANH> NGUCANHs { get; set; }
    }
}
