namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataBind")]
    public partial class DataBind
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string BlockName { get; set; }

        [StringLength(500)]
        public string PartId { get; set; }

        public int? TitleSize { get; set; }

        [StringLength(50)]
        public string BlockTitle { get; set; }

        public int? BlockCount { get; set; }

        public int? DataType { get; set; }

        [StringLength(10)]
        public string DataStyle { get; set; }
    }
}
