using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CafeLab.Models
{
    public class RegInfo
    {
        private string name;
        private string email;
        

        [DisplayName("Please enter first  and last name")]
        [Required]
        [MinLength(10)]
        public string Name { get => Name; set => Name = value; }

        
        [DisplayName("Email")]
        [Required]
        [EmailAddress]
        public string Email { get => email; set => email = value; }

        
    }
}
