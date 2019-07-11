using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MemberRegistrationMVC.Models
{
    public class Member
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter first name.")]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
