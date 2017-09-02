using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ForgingAhead.Models
{
    public class Quest
    {
        [Key]
        public string Name { get; set; }
        public bool IsActive { get; set; }


        public List<Character> Characters { get; set; }
    }
}
