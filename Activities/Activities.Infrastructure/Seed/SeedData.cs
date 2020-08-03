using Activities.Domain.Entities;
using Activities.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Activities.Infrastructure.Seed
{
    public class SeedData
    {
        public static async Task SeedAsync(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            if (!await userManager.Users.AnyAsync())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        DisplayName ="Ramprit Sahani",
                        UserName = "ramprit",
                        Email = "Rampritsahani@gmail.com"
                    }
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pass$$w0rd");
                }
            }
        }
    }
}
