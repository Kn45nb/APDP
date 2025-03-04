using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class NewClass
    {
        [Key]
        public int Id {get;set;}
        [Required]
        [StringLength(50)]
        public string Username {get;set;}
        [Required]
        [StringLength(50)]
        public string Password {get;set;}
        [Required]
        [StringLength(50)]
        public string Email {get;set;}
    }
}