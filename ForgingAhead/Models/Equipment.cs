using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ForgingAhead.Models
{
    public class Equipment
    {
        [Key]
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
    }
}
