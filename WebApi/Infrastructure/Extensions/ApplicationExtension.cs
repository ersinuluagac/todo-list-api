using Entities.Models;
using Microsoft.AspNetCore.Identity;

namespace WebApi.Infrastructure.Extensions
{
    public static class ApplicationExtension
    {
        public static async void ConfigureDefaultAdminUser(this IApplicationBuilder app)
        {
            const string adminUser = "Admin";
            const string adminPassword = "Admin.123";

            UserManager<User> userManager = app
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<UserManager<User>>();

            RoleManager<IdentityRole> roleManager = app
                .ApplicationServices
                .CreateAsyncScope()
                .ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

            User admin = await userManager.FindByNameAsync(adminUser);
            if (admin is null)
            {
                admin = new User()
                {
                    Email = "ersinuluagac@gmail.com",
                    UserName = adminUser,
                };

                var result = await userManager.CreateAsync(admin, adminPassword);

                if (!result.Succeeded)
                {
                    throw new Exception("Admin user creation failed.");
                }

                var roleResult = await userManager.AddToRolesAsync(admin,
                    roleManager
                    .Roles
                    .Select(r => r.Name)
                    .ToList());

                if (!roleResult.Succeeded)
                {
                    throw new Exception("Admin user role assignment failed.");
                }
            }
        }
    }
}
