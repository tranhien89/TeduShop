using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public abstract class Audiable : IAuditable
    {
        public DateTime CreatedDate { set; get; }

        [MaxLength(50)]
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [MaxLength(50)]
        public string UpdatedBy { set; get; }

        [MaxLength(250)]
        public string MetaKeyword { set; get; }

        [MaxLength(250)]
        public string MetaDescription { set; get; }

        public bool? Status { set; get; }
    }
}