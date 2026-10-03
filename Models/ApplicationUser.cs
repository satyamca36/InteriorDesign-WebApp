using Microsoft.AspNetCore.Identity;

namespace InteriorDesign.WebApp.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public string? Address { get; set; }
    public string? ProfileImageUrl { get; set; }
    public bool IsAdmin { get; set; }
}
