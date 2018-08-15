using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(250)]
        public string CustomerAdress { set; get; }

        [Required]
        [MaxLength(250)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName ="varchar")]
        public string CustomerMobile { set; get; }

        [MaxLength(250)]
        public string CustormerMessage { set; get; }

        public DateTime CreatedDate { set; get; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string CreatedBy { set; get; }

        [MaxLength(250)]
        public string PaymentMethod { set; get; }

        [MaxLength(50)]
        public string PaymentStatus { set; get; }

        public bool? Status { set; get; }

        public virtual IEnumerable<OrderDetail> orderdetail { set; get; }
    }
}