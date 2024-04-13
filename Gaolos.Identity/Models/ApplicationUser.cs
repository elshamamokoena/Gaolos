using Microsoft.AspNetCore.Identity;

namespace Gaolos.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ?Name { get; set; }
        public string ?Surname { get; set; }
  
    }
}
