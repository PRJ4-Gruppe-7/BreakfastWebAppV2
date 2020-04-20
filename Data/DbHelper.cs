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
        public static async Task SeedUsersAsync(UserManager<ApplicationUser> userManager, ILogger log)
        {
            const string ReceptionistEmail = "Receptionist@localhost";
            const string ReceptionistPassword = "Password_123";

            if (userManager.FindByNameAsync(ReceptionistEmail).Result == null)
            {
                log.LogWarning("Seeding the Receptionist user");
                var user = new ApplicationUser
                {
                    UserName = ReceptionistEmail,
                    Email = ReceptionistEmail,
                    FullName = "Bente Bent",
                    Role = "Receptionist",
                    EmailConfirmed = true
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
            const string WaiterPassword = "Password_123";

            if (userManager.FindByNameAsync(WaiterEmail).Result == null)
            {
                log.LogWarning("Seeding the Waiter user");
                var user = new ApplicationUser
                {

                    UserName = WaiterEmail,
                    Email = WaiterEmail,
                    FullName = "Morten Lenschow",
                    Role = "Waiter",
                    EmailConfirmed = true
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
            const string CookPassword = "Password_123";


            if (userManager.FindByNameAsync(CookEmail).Result == null)
            {
                log.LogWarning("Seeding the Cook user");
                var user = new ApplicationUser
                {

                    UserName = CookEmail,
                    Email = CookEmail,
                    FullName = "Ralle",
                    Role = "Cook",
                    EmailConfirmed = true
                };
                IdentityResult result = userManager.CreateAsync
                    (user, CookPassword).Result;
                if (result.Succeeded)
                {
                    var CookClaim = new Claim("Cook", "Yes");
                    userManager.AddClaimAsync(user, CookClaim);
                }
            }




            // For deletion of the users
            //userManager.DeleteAsync(userManager.FindByNameAsync(ReceptionistEmail).Result);
            //userManager.DeleteAsync(userManager.FindByNameAsync(CookEmail).Result);
            //userManager.DeleteAsync(userManager.FindByNameAsync(WaiterEmail).Result);





        }
    }
}
