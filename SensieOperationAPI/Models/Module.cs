using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SensieOperationAPI.Models
{
    public partial class Module
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Module()
        {
            ActivationCodes = new HashSet<ActivationCode>();
        }

        [Key]
        public int ModuloId { get; set; }

        [Required]
        [StringLength(50)]
        public string ModuloKey { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Environment { get; set; }

        public bool Enabled { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivationCode> ActivationCodes { get; set; }
    }
}
