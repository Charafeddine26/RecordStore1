using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordStore.Data;

namespace RecordStore1.Controllers
{
    public class ArtistesController : Controller
    {
        private readonly AppDbContext _context;

        public ArtistesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allArtistes = await _context.Artistes.ToListAsync();

            return View(allArtistes);
        }
    }
}
