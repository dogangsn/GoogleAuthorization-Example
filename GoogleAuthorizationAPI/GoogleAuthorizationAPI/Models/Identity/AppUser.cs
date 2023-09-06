using Microsoft.AspNetCore.Identity;

namespace GoogleAuthorizationAPI.Models.Identity
{
    public class AppUser : IdentityUser<string>
    {
        public string Provider { get; set; }
    }
}
