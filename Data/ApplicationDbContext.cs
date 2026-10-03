using InteriorDesign.WebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InteriorDesign.WebApp.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Project> Projects => Set<Project>();
    public DbSet<ServiceItem> ServiceItems => Set<ServiceItem>();
    public DbSet<Testimonial> Testimonials => Set<Testimonial>();
    public DbSet<Inquiry> Inquiries => Set<Inquiry>();
    public DbSet<BlogPost> BlogPosts => Set<BlogPost>();
}
