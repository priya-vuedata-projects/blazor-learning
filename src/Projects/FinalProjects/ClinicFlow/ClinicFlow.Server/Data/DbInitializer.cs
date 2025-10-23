using Microsoft.AspNetCore.Identity;

namespace ClinicFlow.Server.Data
{
    public static class DbInitializer
    {
        public static async Task SeedUsersAndRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // Define roles
            string[] roles = { "Admin", "Doctor" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            // Create Admin user
            var adminUser = await userManager.FindByEmailAsync("admin@clinicflow.com");
            if (adminUser == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@clinicflow.com",
                    Email = "admin@clinicflow.com",
                    FullName = "System Administrator",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(user, "Admin@123");
                if (result.Succeeded)
                    await userManager.AddToRoleAsync(user, "Admin");
            }

            // Create Doctor user
            var doctorUser = await userManager.FindByEmailAsync("dr.alice@clinicflow.com");
            if (doctorUser == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "dr.alice@clinicflow.com",
                    Email = "dr.alice@clinicflow.com",
                    FullName = "Clinic doctor",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(user, "Doctor@123");
                if (result.Succeeded)
                    await userManager.AddToRoleAsync(user, "Doctor");
            }
        }
    }
}
