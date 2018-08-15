using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [MaxLength(250)]
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }
    }
}