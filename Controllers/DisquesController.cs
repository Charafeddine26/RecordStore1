using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordStore.Data;

namespace RecordStore1.Controllers
{
    public class DisquesController : Controller
    {
        private readonly AppDbContext _context;

        public DisquesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allDisques = await _context.Disques.Include(n => n.Label).Include(m => m.Genre).ToListAsync();
            return View(allDisques);
        }
    }
}
