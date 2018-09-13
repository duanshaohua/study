namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Advertise")]
    public partial class Advertise
    {
        public int Id { get; set; }

        public int? AdvertisementId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [StringLength(1000)]
        public string Link { get; set; }

        [StringLength(1000)]
        public string Intro { get; set; }

        public bool? Display { get; set; }

        public int? Sequence { get; set; }

        public virtual Advertisement Advertisement { get; set; }
    }
}
