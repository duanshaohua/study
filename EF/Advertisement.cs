namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Advertisement")]
    public partial class Advertisement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Advertisement()
        {
            Advertise = new HashSet<Advertise>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Codein { get; set; }

        [StringLength(300)]
        public string Codeem { get; set; }

        [StringLength(100)]
        public string Width { get; set; }

        [StringLength(100)]
        public string Height { get; set; }

        public bool? Enable { get; set; }

        public int? ShowType { get; set; }

        public DateTime? StartTime { get; set; }

        public int? ValidPeriod { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advertise> Advertise { get; set; }
    }
}
