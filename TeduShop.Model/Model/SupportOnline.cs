﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [MaxLength(250)]
        public string Department { set; get; }

        [MaxLength(250)]
        public string Skype { set; get; }

        [MaxLength(250)]
        public string FaceBook { set; get; }

        [MaxLength(250)]
        public string Mobile { set; get; }

        [MaxLength(250)]
        public string Email { set; get; }

        public bool? Status { set; get; }
    }
}