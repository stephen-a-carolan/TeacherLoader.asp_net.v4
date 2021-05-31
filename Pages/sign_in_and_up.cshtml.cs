using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace SparkAutomation.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

    }
}  


namespace TeacherLoader.asp_net.v1.Pages
{
    public class sign_in_and_upModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
