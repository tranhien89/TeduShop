using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("VistorStatistics")]
   public  class VistorStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public DateTime VisitedDate { set; get; }

        [MaxLength(250)]
        public string IPAddress { set; get; }
    }
}
