using Microsoft.AspNetCore.Identity;

namespace SpacDYNa.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
