using InteriorDesign.WebApp.Models;

namespace InteriorDesign.WebApp.Models;

public class LoginViewModel
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool RememberMe { get; set; }
}

public class RegisterViewModel
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string ConfirmPassword { get; set; } = string.Empty;
}

public class AdminDashboardViewModel
{
    public int TotalProjects { get; set; }
    public int TotalInquiries { get; set; }
    public int TotalUsers { get; set; }
    public List<Project> RecentProjects { get; set; } = new();
}

public class HomeViewModel
{
    public List<Project> FeaturedProjects { get; set; } = new();
    public List<ServiceItem> Services { get; set; } = new();
    public List<Testimonial> Testimonials { get; set; } = new();
    public List<BlogPost> BlogPosts { get; set; } = new();
}
