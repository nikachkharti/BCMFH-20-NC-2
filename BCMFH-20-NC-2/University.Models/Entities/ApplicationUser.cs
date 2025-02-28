using Microsoft.AspNetCore.Identity;

namespace University.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
