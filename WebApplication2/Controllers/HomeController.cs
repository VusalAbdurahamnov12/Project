using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.DAL;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVm homeVm = new HomeVm
            {
                Teams = await _context.Teams.Include(n => n.TeamSocials).ToListAsync(),
                Slogans = await _context.Slogans.ToListAsync(),
                Statisticas = await _context.Statisticas.ToListAsync(),
                Comments = await _context.Comments.ToListAsync(),
                Sliders = await _context.Sliders.ToListAsync(),
                Partniors = await _context.Partniors.ToListAsync(),
                Settings = await _context.Settings.ToListAsync(),
            };
            return View(homeVm);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Contact(Contact contact)
        {
            if (!ModelState.IsValid) return View();

            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();

            TempData["successfull"] = "You message hase been successfull sended.";

            return RedirectToAction("Index");
        }
    }
}
