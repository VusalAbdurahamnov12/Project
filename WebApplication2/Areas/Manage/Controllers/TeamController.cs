using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.DAL;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Areas.Manage.Controllers
{
     [Area("Manage")]
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        public TeamController(AppDbContext context)
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
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public  IActionResult Create(Team NewTeam,TeamSocial teamSocial)
        {
            _context.Teams.Add(NewTeam);
            _context.SaveChanges();
            _context.SaveChanges();
            return RedirectToAction("Create");
        }

        public  IActionResult Delete(int id)
        {
            Team Team = _context.Teams.FirstOrDefault(x => x.Id == id);
            _context.Teams.Remove(Team);
            _context.SaveChanges();
            if (Team == null) return NotFound();
            return RedirectToAction("Index");
        }

        public IActionResult Update(Team team, int id)
        {
            Team ExistDb = _context.Teams.FirstOrDefault(x => x.Id == id);
            if (ExistDb == null) return NotFound();
            if (ExistDb.Id == team.Id)
            {
            ExistDb.Work = team.Work;
            ExistDb.Name = team.Name;
            ExistDb.Image = team.Image;
            ExistDb.TeamSocials = team.TeamSocials;
            }

            return RedirectToAction("Index");
        }
    }
}
