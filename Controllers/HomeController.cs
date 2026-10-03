using InteriorDesign.WebApp.Data;
using InteriorDesign.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InteriorDesign.WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var featuredProjects = await _context.Projects
            .Where(p => p.IsFeatured)
            .OrderByDescending(p => p.CreatedAt)
            .Take(3)
            .ToListAsync();

        var services = await _context.ServiceItems.ToListAsync();
        var testimonials = await _context.Testimonials.Take(3).ToListAsync();
        var blogPosts = await _context.BlogPosts.Take(2).ToListAsync();

        var model = new HomeViewModel
        {
            FeaturedProjects = featuredProjects,
            Services = services,
            Testimonials = testimonials,
            BlogPosts = blogPosts
        };

        return View(model);
    }

    public IActionResult About()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Contact()
    {
        return View(new Inquiry());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Contact(Inquiry inquiry)
    {
        if (!ModelState.IsValid)
        {
            return View(inquiry);
        }

        _context.Inquiries.Add(inquiry);
        await _context.SaveChangesAsync();

        TempData["SuccessMessage"] = "Thank you! Your inquiry has been submitted successfully.";
        return RedirectToAction(nameof(Contact));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
}
