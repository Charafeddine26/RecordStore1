using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordStore.Data;

namespace RecordStore1.Controllers
{
    public class LabelsController : Controller
    {
        private readonly AppDbContext _context;

        public LabelsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allLabels = await _context.Labels.ToListAsync();
            return View(allLabels);
        }
    }
}
