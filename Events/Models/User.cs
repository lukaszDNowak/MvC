using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Models
{
    public class User
    {
        
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Nie podałeś nazwy")]
        [Display(Name="Imię")]
       
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Numer Telefonu")]
        public string Phone { get; set; }
        public DateTime Created { get; set; }

    }
}
