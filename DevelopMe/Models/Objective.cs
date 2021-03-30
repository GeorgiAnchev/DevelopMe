using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopMe.Models
{
    public class Objective
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Short description")]
        public string ShortDescription { get; set; }
        
        [StringLength(255)]
        [Display(Name = "Long description")]
        public string LongDescription { get; set; }

        public IdentityUser Owner { get; set; }

    }
}
