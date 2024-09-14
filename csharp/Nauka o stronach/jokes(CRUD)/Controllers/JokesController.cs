using System;

namespace jokes_CRUD_.Controllers
{
    public class JokesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public JokesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Joke.ToListAsync());
        }
    }
}