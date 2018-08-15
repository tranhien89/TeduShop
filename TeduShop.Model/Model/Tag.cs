using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(250)]
        public string Alias { set; get; }

        public string Type { set; get; }

        public virtual List<PostTag> PosTag { set; get; }

        public virtual List<ProductTag> ProductTag { set; get; }
    }
}