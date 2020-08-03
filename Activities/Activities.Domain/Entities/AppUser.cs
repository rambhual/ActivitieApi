using Microsoft.AspNetCore.Identity;

namespace Activities.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
    }
}
