using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;
using SpacDYNa.DAL;
using SpacDYNa.Models;
using SpacDYNa.ViewModels;

namespace SpacDYNa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CardController(DYNaContext _context) : Controller
    {
















        public async Task<IActionResult> Index()
        {
            return View(await _context.Cards.Select(c => new GetCardsVM
            {
                Id = c.Id,
                Name = c.Name,
                SubTitle = c.SubTitle,
                ImageUrl = c.ImageUrl,

            }).ToListAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCardsVM vm)
        {
            if (vm == null) return BadRequest();

            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            Card card = new Card
            {
                Name = vm.Name,
                SubTitle = vm.SubTitle,
                ImageUrl = vm.ImageUrl
            };
            await _context.Cards.AddAsync(card);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));


        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null && id < 1)
            {
                return BadRequest();
            }
            var data = await _context.Cards.FindAsync(id);
            _context.Cards.Remove(data);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
        public async Task<IActionResult> Update(int? id)

        {
            if (id is null && id < 1)
                return BadRequest();
            var data = await _context.Cards.FindAsync(id);
            if (data is null)
                return NotFound();


            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id, UpdateCardsVM vm)
        {
            if (id is null && id < 1)
                return BadRequest();
            var data = await _context.Cards.FindAsync(id);
            if (data is null)
                return NotFound();

            data.Name = vm.Name;
            data.SubTitle = vm.SubTitle;
            data.ImageUrl = vm.ImageUrl;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

    }
}
