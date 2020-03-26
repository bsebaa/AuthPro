using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthPro.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage="Password not match")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Job Description")]
        public string JobDescription { get; set; }

        [Display(Name = "Department Location")]
        public string DepartmentLocation { get; set; }

        [Display(Name = "IGG")]
        public string IGG { get; set; }

    }
}
