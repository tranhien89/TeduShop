﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    [Table("PostCategories")]
    public class PostCategory : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [Required]
        [MaxLength(250)]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? ParentId { set; get; }
        public int? DisplayOrder { set; get; }

        [MaxLength(250)]
        public string Image { set; get; }

        public bool? HomeFLag { set; get; }

        public virtual IEnumerable<Post> Post { set; get; }
    }
}