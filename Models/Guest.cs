using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AuthSystem.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime CurrentDate { get; set; }

        [Required]
        [StringLength(140, MinimumLength = 2)]
        [DataType(DataType.MultilineText)]
        public string CurrentText { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
