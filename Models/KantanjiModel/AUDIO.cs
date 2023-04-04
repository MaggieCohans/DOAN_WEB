namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AUDIO")]
    public partial class AUDIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUDIO()
        {
            DENGHEs = new HashSet<DENGHE>();
        }

        [Key]
        public int IDAUDIO { get; set; }

        [Required]
        [StringLength(150)]
        public string LINKAUDIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DENGHE> DENGHEs { get; set; }
    }
}
