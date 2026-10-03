using System.ComponentModel.DataAnnotations;

namespace InteriorDesign.WebApp.Models;

public class ServiceItem
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty;

    public string IconCss { get; set; } = "fa-home";
}
