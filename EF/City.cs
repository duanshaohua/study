namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("City")]
    public partial class City
    {
        public int Id { get; set; }

        public int? Pid { get; set; }

        public int? Level { get; set; }

        public int? Sort { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public int? Unit { get; set; }

        [StringLength(200)]
        public string ZipCode { get; set; }

        [StringLength(100)]
        public string AreaCode { get; set; }

        public bool? Serve { get; set; }

        public bool? Delete { get; set; }

        public DateTime? DeleteTime { get; set; }

        [StringLength(200)]
        public string Key { get; set; }
    }
}
