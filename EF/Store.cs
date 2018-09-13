namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            Goods = new HashSet<Goods>();
            StoreManage = new HashSet<StoreManage>();
        }

        public int Id { get; set; }

        public int? Owner { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(8000)]
        public string Intro { get; set; }

        [StringLength(100)]
        public string Province { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string District { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Coordinate { get; set; }

        [StringLength(100)]
        public string Contact { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public int? Industry { get; set; }

        [StringLength(8000)]
        public string AboutUs { get; set; }

        [StringLength(200)]
        public string Facade { get; set; }

        public int? Flow { get; set; }

        public bool Enabled { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods> Goods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreManage> StoreManage { get; set; }
    }
}
