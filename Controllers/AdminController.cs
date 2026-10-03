using InteriorDesign.WebApp.Data;
using InteriorDesign.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InteriorDesign.WebApp.Controllers;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;

    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Dashboard()
    {
        var model = new AdminDashboardViewModel
        {
            TotalProjects = await _context.Projects.CountAsync(),
            TotalInquiries = await _context.Inquiries.CountAsync(),
            TotalUsers = await _context.Users.CountAsync(),
            RecentProjects = await _context.Projects.OrderByDescending(p => p.CreatedAt).Take(5).ToListAsync()
        };

        return View(model);
    }

    public async Task<IActionResult> Projects()
    {
        var projects = await _context.Projects.OrderByDescending(p => p.CreatedAt).ToListAsync();
        return View(projects);
    }

    [HttpGet]
    public IActionResult CreateProject()
    {
        return View(new Project());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateProject(Project project)
    {
        if (!ModelState.IsValid)
        {
            return View(project);
        }

        project.Slug = project.Title.Trim();
        project.Slug = project.Slug.Replace(" ", "-").ToLower();
        _context.Projects.Add(project);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Projects));
    }

    [HttpGet]
    public async Task<IActionResult> EditProject(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null)
        {
            return NotFound();
        }

        return View(project);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditProject(Project project)
    {
        if (!ModelState.IsValid)
        {
            return View(project);
        }

        _context.Update(project);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Projects));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteProject(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null)
        {
            return NotFound();
        }

        _context.Projects.Remove(project);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Projects));
    }
}
