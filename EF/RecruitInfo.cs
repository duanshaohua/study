namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecruitInfo")]
    public partial class RecruitInfo
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Zhiweimingcheng { get; set; }

        [StringLength(100)]
        public string Zhiweileixing { get; set; }

        [StringLength(100)]
        public string Zhiweiyaoqiu { get; set; }

        public int? Zhaopinrenshu { get; set; }

        [StringLength(100)]
        public string Zhaopinbumen { get; set; }

        [StringLength(100)]
        public string Xingbieyaoqiu { get; set; }

        [StringLength(500)]
        public string Gongzuojingyan { get; set; }

        [StringLength(500)]
        public string Gongzuodiqu { get; set; }

        [StringLength(1000)]
        public string Yaoqiuyudaiyu { get; set; }

        [StringLength(20)]
        public string Lianxiren { get; set; }

        [StringLength(20)]
        public string Lianxidianhua { get; set; }

        [StringLength(20)]
        public string Danweichuanzhen { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(500)]
        public string Tongxindizhi { get; set; }

        public DateTime? Addtime { get; set; }

        [StringLength(100)]
        public string Xueli { get; set; }
    }
}
