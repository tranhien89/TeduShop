using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [MaxLength(250)]
        public string Name { set; get; }

        public string Content { set; get; }

        [MaxLength(250)]
        public string MetaDescription { set; get; }

        [MaxLength(250)]
        public string MetaKeyword { set; get; }

        public bool? Status { set; get; }
    }
}