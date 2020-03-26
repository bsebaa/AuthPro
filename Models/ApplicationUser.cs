using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthPro.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string JobDescription { get; set; }
        public string DepartmentLocation { get; set; }
        public string IGG { get; set; }
    }
}
