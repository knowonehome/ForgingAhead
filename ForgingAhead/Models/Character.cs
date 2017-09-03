using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ForgingAhead.Models
{
    public class Character
    {
        [Key]
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Display(Name = "Is Active")]
        [Required]
        public bool IsActive { get; set; }
        [Required]
        [Range(1, 20)]
        public int Level { get; set; }
        [Required]
        [Range(1,18)]
        public int Strength { get; set; }
        [Required]
        [Range(1, 18)]
        public int Dexterity { get; set; }
        [Required]
        [Range(1, 18)]
        public int Intelligence { get; set; }

        public List<Equipment> Equipment { get; set; }
    }
}
