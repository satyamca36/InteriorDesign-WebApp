using InteriorDesign.WebApp.Data;
using InteriorDesign.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InteriorDesign.WebApp.Controllers;

[Authorize]
public class UserController : Controller
{
    private readonly ApplicationDbContext _context;

    public UserController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Dashboard()
    {
        var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity!.Name);
        var inquiries = await _context.Inquiries
            .Where(i => i.UserId == currentUser?.Id || i.Email == currentUser?.Email)
            .OrderByDescending(i => i.CreatedAt)
            .ToListAsync();

        return View(inquiries);
    }
}
