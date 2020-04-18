using BreakfastWebAppV2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BreakfastWebAppV2.Data
{
    public class DbHelper
    {
        public static void SeedUsers(UserManager<ApplicationUser> userManager, ILogger log)
        {
            const string ReceptionistEmail = "Receptionist@localhost";
            const string ReceptionistPassword = "password";

            if (userManager.FindByNameAsync(ReceptionistEmail).Result == null)
            {
                log.LogWarning("Seeding the Receptionist user");
                var user = new ApplicationUser
                {
                    UserName = ReceptionistEmail,
                    Email = ReceptionistEmail,
                    Name = "Bente Bent",
                    Role = "Receptionist"
                };
                IdentityResult result = userManager.CreateAsync
                    (user, ReceptionistPassword).Result;
                if (result.Succeeded)
                {
                    var ReceptionistClaim = new Claim("Receptionist", "Yes");
                    userManager.AddClaimAsync(user, ReceptionistClaim);
                }
            }



            const string WaiterEmail = "Waiter@localhost";
            const string WaiterPassword = "password";

            if (userManager.FindByNameAsync(WaiterEmail).Result == null)
            {
                log.LogWarning("Seeding the Waiter user");
                var user = new ApplicationUser
                {

                    UserName = WaiterEmail,
                    Email = WaiterEmail,
                    Name = "Morten Lenschow",
                    Role = "Waiter"
                };
                IdentityResult result = userManager.CreateAsync
                    (user, WaiterPassword).Result;
                if (result.Succeeded)
                {
                    var WaiterClaim = new Claim("Waiter", "Yes");
                    userManager.AddClaimAsync(user, WaiterClaim);
                }
            }



            const string CookEmail = "Cook@localhost";
            const string CookPassword = "password";

            if (userManager.FindByNameAsync(CookEmail).Result == null)
            {
                log.LogWarning("Seeding the Cook user");
                var user = new ApplicationUser
                {

                    UserName = CookEmail,
                    Email = CookEmail,
                    Name = "Ralle",
                    Role = "Cook"
                };
                IdentityResult result = userManager.CreateAsync
                    (user, CookPassword).Result;
                if (result.Succeeded)
                {
                    var CookClaim = new Claim("Cook", "Yes");
                    userManager.AddClaimAsync(user, CookClaim);
                }
            }


        }
    }
}
