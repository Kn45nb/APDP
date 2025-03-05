using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class InputData
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 1)]
        public string Text { get; set; } = string.Empty;
    }
}