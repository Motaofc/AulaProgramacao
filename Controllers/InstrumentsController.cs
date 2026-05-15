using Microsoft.AspNetCore.Mvc;
using a14468_employes_management.Data;
using a14468_employes_management.Models;

namespace a14468_employes_management.Controllers
{
    public class InstrumentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstrumentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // LISTAR
        public IActionResult Index()
        {
            var instruments = _context.Instruments.ToList();
            return View(instruments);
        }

        // CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        public IActionResult Create(Instrument instrument)
        {
            if (ModelState.IsValid)
            {
                _context.Instruments.Add(instrument);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(instrument);
        }

        // EDIT GET
        public IActionResult Edit(int id)
        {
            var instrument = _context.Instruments.Find(id);

            if (instrument == null)
            {
                return NotFound();
            }

            return View(instrument);
        }

        // EDIT POST
        [HttpPost]
        public IActionResult Edit(Instrument instrument)
        {
            if (ModelState.IsValid)
            {
                _context.Instruments.Update(instrument);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(instrument);
        }

        // DELETE GET
        public IActionResult Delete(int id)
        {
            var instrument = _context.Instruments.Find(id);

            if (instrument == null)
            {
                return NotFound();
            }

            return View(instrument);
        }

        // DELETE POST
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var instrument = _context.Instruments.Find(id);

            if (instrument != null)
            {
                _context.Instruments.Remove(instrument);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}