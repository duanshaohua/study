namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreManage")]
    public partial class StoreManage
    {
        public int Id { get; set; }

        public int? Store { get; set; }

        public int? Member { get; set; }

        public byte? Type { get; set; }

        public int? Role { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string WeChatOpenId { get; set; }

        public bool? Enabled { get; set; }

        public virtual Store Store1 { get; set; }
    }
}
