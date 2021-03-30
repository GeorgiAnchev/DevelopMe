using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopMe.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Employee name")]
        public string Name { get; set; }

        

    }
}
