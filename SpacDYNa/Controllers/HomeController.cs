using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpacDYNa.DAL;
using SpacDYNa.ViewModels;

namespace SpacDYNa.Controllers
{
    public class HomeController(DYNaContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
           return View(await _context.Cards.Select(c=>new GetCardsVM
           {
               Name = c.Name,
               ImageUrl = c.ImageUrl,
               SubTitle = c.SubTitle,
           }).ToListAsync());
        }
    }
}
