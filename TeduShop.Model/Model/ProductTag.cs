﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { set; get; }

        [Key]
        public string TagID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}