using System.ComponentModel.DataAnnotations;

namespace InteriorDesign.WebApp.Models;

public class Testimonial
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string ProjectName { get; set; } = string.Empty;

    [Required]
    public string Quote { get; set; } = string.Empty;

    [Range(1, 5)]
    public int Rating { get; set; }
}
