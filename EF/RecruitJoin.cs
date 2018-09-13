namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecruitJoin")]
    public partial class RecruitJoin
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Xingming { get; set; }

        [StringLength(10)]
        public string Xingbie { get; set; }

        public int? Nianling { get; set; }

        [StringLength(20)]
        public string Minzu { get; set; }

        [StringLength(20)]
        public string Chushengriqi { get; set; }

        [StringLength(10)]
        public string Shengao { get; set; }

        [StringLength(20)]
        public string Shenfenzhenghao { get; set; }

        [StringLength(100)]
        public string Jiguan { get; set; }

        [StringLength(20)]
        public string Xueli { get; set; }

        [StringLength(100)]
        public string Zanzhudizhi { get; set; }

        public DateTime? Biyeshijian { get; set; }

        [StringLength(50)]
        public string Biyeyuanxiao { get; set; }

        [StringLength(20)]
        public string Waiyushuiping { get; set; }

        [StringLength(20)]
        public string Hunfou { get; set; }

        [StringLength(200)]
        public string Zhuanyetechang { get; set; }

        [StringLength(20)]
        public string Beiyong { get; set; }

        public int? Gongling { get; set; }

        [StringLength(100)]
        public string Yingpingangwei { get; set; }

        [StringLength(1000)]
        public string Daiyuyaoqiu { get; set; }

        [StringLength(20)]
        public string Lianxidianhua { get; set; }

        [StringLength(20)]
        public string Shouji { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(1000)]
        public string Xuexijingli { get; set; }

        [StringLength(1000)]
        public string Gongzuojingli { get; set; }

        [StringLength(1000)]
        public string Gerenjianli { get; set; }

        public bool? Read { get; set; }

        public DateTime? Addtime { get; set; }
    }
}
