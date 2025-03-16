using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpellLista.Models;

namespace SpellLista.Controllers
{
    public class SpelController : Controller
    {
        private readonly AppDbContext _context;

        public SpelController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Userspel()
        {
            var userGames = await _context.Spel.ToListAsync();

            return View(userGames);
        }




        public async Task<IActionResult> Index()
        {
            var spel = await _context.Spel.ToListAsync();  
            return View(spel);  
        }

        
        public IActionResult Skapa()
        {
            return View();  
        }

        
        [HttpPost]
        [HttpPost]
        public async Task<IActionResult> Skapa(Spel spel)
        {
            if (ModelState.IsValid)
            {
                _context.Spel.Add(spel); 
                await _context.SaveChangesAsync(); 
                return RedirectToAction("Index"); 
            }
            return View(spel); 
        }


        // Ta bort ett spel
        public async Task<IActionResult> Radera(int id)
        {
            var spel = await _context.Spel.FindAsync(id);  
            if (spel != null)
            {
                _context.Spel.Remove(spel);  
                await _context.SaveChangesAsync();  
            }
            return RedirectToAction(nameof(Index));  
        }
    }
}
