namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MemberOrders
    {
        public int Id { get; set; }

        public int? Type { get; set; }

        public int? Member { get; set; }

        public int? Store { get; set; }

        public int? PayWay { get; set; }

        public decimal? PayablePrice { get; set; }

        public decimal? RealPrice { get; set; }

        public decimal? OrderPrice { get; set; }

        public int? Address { get; set; }

        public int? Delivery { get; set; }

        public decimal? Freight { get; set; }

        [StringLength(100)]
        public string TradeNo { get; set; }

        [StringLength(100)]
        public string Waybill { get; set; }

        public bool? Invoice { get; set; }

        [StringLength(500)]
        public string InvoiceTitle { get; set; }

        public decimal? InvoicePrice { get; set; }

        public int? State { get; set; }

        public DateTime? OrderTime { get; set; }

        public DateTime? PaymentTime { get; set; }

        public DateTime? DeliveryTime { get; set; }

        public DateTime? ReceiveTime { get; set; }

        public byte? ReceiveType { get; set; }

        [StringLength(1000)]
        public string Evaluation { get; set; }

        [StringLength(50)]
        public string Rating { get; set; }

        [StringLength(50)]
        public string ServiceAttitude { get; set; }

        public bool? EvaluationAuditing { get; set; }

        public bool? View { get; set; }

        [Column(TypeName = "text")]
        public string Feedback { get; set; }

        [StringLength(500)]
        public string Describe { get; set; }

        public bool? Balance { get; set; }
    }
}
