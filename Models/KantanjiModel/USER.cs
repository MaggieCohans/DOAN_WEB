namespace DOAN_WEB.Models.KantanjiModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            THONGTINs = new HashSet<THONGTIN>();
        }

        [Key]
        public int IDUSER { get; set; }

        [Required]
        [StringLength(255)]
        public string TAIKHOAN { get; set; }

        [Required]
        [StringLength(255)]
        public string ENPASSWORD { get; set; }

        public bool? TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THONGTIN> THONGTINs { get; set; }
    }
}
