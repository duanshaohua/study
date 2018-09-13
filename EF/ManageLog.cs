namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManageLog")]
    public partial class ManageLog
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        public int? Manage { get; set; }

        public DateTime? Time { get; set; }

        [StringLength(500)]
        public string Record { get; set; }
    }
}
