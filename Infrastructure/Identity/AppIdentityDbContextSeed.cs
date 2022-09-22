using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager) 
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Sherlock",
                    Email = "sherlock@scotyard.com",
                    UserName = "sherlock@scotyard.com",
                    Address = new Address
                    {
                        FirstName = "Sherlock",
                        LastName = "Holmes",
                        Street = "221B Baker Street",
                        City = "London",
                        County = "London", 
                        PostCode = "NW1 6XE"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}