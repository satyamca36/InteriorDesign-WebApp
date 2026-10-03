using System.ComponentModel.DataAnnotations;

namespace InteriorDesign.WebApp.Models;

public class Project
{
    public int Id { get; set; }

    [Required]
    [StringLength(120)]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Slug { get; set; } = string.Empty;

    [Required]
    [StringLength(1000)]
    public string Description { get; set; } = string.Empty;

    [Required]
    [StringLength(60)]
    public string Category { get; set; } = string.Empty;

    [Required]
    [StringLength(120)]
    public string Location { get; set; } = string.Empty;

    [Url]
    public string ImageUrl { get; set; } = string.Empty;

    [Range(0, 100000000)]
    public decimal Budget { get; set; }

    public bool IsFeatured { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string? CreatedByUserId { get; set; }
    public ApplicationUser? CreatedByUser { get; set; }
}
