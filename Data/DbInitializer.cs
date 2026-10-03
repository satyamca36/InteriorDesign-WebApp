using InteriorDesign.WebApp.Data;
using InteriorDesign.WebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InteriorDesign.WebApp.Data;

public static class DbInitializer
{
    public static async Task InitializeAsync(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        await context.Database.EnsureCreatedAsync();

        var roles = new[] { "Admin", "User" };
        foreach (var roleName in roles)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        const string adminEmail = "admin@interiorhome.com";
        var adminUser = await userManager.FindByEmailAsync(adminEmail);
        if (adminUser == null)
        {
            adminUser = new ApplicationUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                FullName = "System Admin",
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(adminUser, "Admin@123");
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
        else if (!await userManager.IsInRoleAsync(adminUser, "Admin"))
        {
            await userManager.AddToRoleAsync(adminUser, "Admin");
        }

        if (!context.ServiceItems.Any())
        {
            context.ServiceItems.AddRange(
                new ServiceItem { Name = "Interior Design", Description = "Turnkey interior styling that balances function, comfort, and luxury.", IconCss = "fa-palette" },
                new ServiceItem { Name = "Space Planning", Description = "Smart layouts designed to maximize flow, comfort, and usable area.", IconCss = "fa-ruler-combined" },
                new ServiceItem { Name = "Furniture Styling", Description = "Curated commercial and residential furniture packages for every room.", IconCss = "fa-couch" },
                new ServiceItem { Name = "Renovation Support", Description = "End-to-end redesign support to coordinate finishes, suppliers, and execution.", IconCss = "fa-hammer" }
            );
        }

        if (!context.Testimonials.Any())
        {
            context.Testimonials.AddRange(
                new Testimonial { Name = "Priya S.", ProjectName = "Skyline Residence", Quote = "The team transformed our home into a warm, premium living experience with a perfect balance of aesthetics and comfort.", Rating = 5 },
                new Testimonial { Name = "Vikram N.", ProjectName = "Harbor Villa", Quote = "They elevated our interiors while respecting our budget and timeline. Every detail felt considered.", Rating = 5 },
                new Testimonial { Name = "Ayesha K.", ProjectName = "Boutique Office", Quote = "Our workspace feels more refined and productive than ever. Their design direction was exceptional.", Rating = 5 }
            );
        }

        if (!context.Projects.Any())
        {
            context.Projects.AddRange(
                new Project
                {
                    Title = "Modern Family Villa",
                    Description = "A richly layered luxury villa with warm wooden textures, natural light, and statement contemporary finishes.",
                    Category = "Residential",
                    Location = "Bengaluru",
                    Budget = 1800000m,
                    ImageUrl = "https://images.unsplash.com/photo-1505693416388-ac5ce068fe85?auto=format&fit=crop&w=1200&q=80",
                    IsFeatured = true,
                    Slug = "modern-family-villa"
                },
                new Project
                {
                    Title = "City Loft Retreat",
                    Description = "A striking loft concept built for open living, soft textures, and a metropolitan design language.",
                    Category = "Apartment",
                    Location = "Mumbai",
                    Budget = 900000m,
                    ImageUrl = "https://images.unsplash.com/photo-1494526585095-c41746248156?auto=format&fit=crop&w=1200&q=80",
                    IsFeatured = true,
                    Slug = "city-loft-retreat"
                },
                new Project
                {
                    Title = "Boutique Workspace",
                    Description = "A refined office interior designed for productivity, hospitality, and flexible collaboration zones.",
                    Category = "Commercial",
                    Location = "Pune",
                    Budget = 1200000m,
                    ImageUrl = "https://images.unsplash.com/photo-1484154218962-a197022b5858?auto=format&fit=crop&w=1200&q=80",
                    IsFeatured = true,
                    Slug = "boutique-workspace"
                }
            );
        }

        if (!context.BlogPosts.Any())
        {
            context.BlogPosts.AddRange(
                new BlogPost { Title = "Designing Cozy Luxury for Family Homes", Content = "Modern interiors thrive on balance: soft materials, layered lighting, and intentional furniture planning.", ImageUrl = "https://images.unsplash.com/photo-1505693416388-ac5ce068fe85?auto=format&fit=crop&w=1100&q=80" },
                new BlogPost { Title = "3 Ways to Make Small Spaces Feel Grand", Content = "Discover how mirrors, tone-on-tone palettes, and smart layouts can transform compact homes.", ImageUrl = "https://images.unsplash.com/photo-1505693416388-ac5ce068fe85?auto=format&fit=crop&w=1100&q=80" }
            );
        }

        await context.SaveChangesAsync();
    }
}
