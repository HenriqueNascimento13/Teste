using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HHSBooking;

namespace HHSBooking.Controllers
{
    public class TipoQuartoesController : Controller
    {
        private readonly BookingContext _context;

        public TipoQuartoesController(BookingContext context)
        {
            _context = context;
        }

        // GET: TipoQuartoes
        public async Task<IActionResult> Index()
        {
            var bookingContext = _context.TipoQuarto.Include(t => t.IdhotelNavigation);
            return View(await bookingContext.ToListAsync());
        }

        // GET: TipoQuartoes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoQuarto = await _context.TipoQuarto
                .Include(t => t.IdhotelNavigation)
                .FirstOrDefaultAsync(m => m.IdtipoQuarto == id);
            if (tipoQuarto == null)
            {
                return NotFound();
            }

            return View(tipoQuarto);
        }

        // GET: TipoQuartoes/Create
        public IActionResult Create()
        {
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal");
            return View();
        }

        // POST: TipoQuartoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdtipoQuarto,Idhotel,Capacidade,Inventario,Descricao")] TipoQuarto tipoQuarto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoQuarto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", tipoQuarto.Idhotel);
            return View(tipoQuarto);
        }

        // GET: TipoQuartoes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoQuarto = await _context.TipoQuarto.FindAsync(id);
            if (tipoQuarto == null)
            {
                return NotFound();
            }
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", tipoQuarto.Idhotel);
            return View(tipoQuarto);
        }

        // POST: TipoQuartoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("IdtipoQuarto,Idhotel,Capacidade,Inventario,Descricao")] TipoQuarto tipoQuarto)
        {
            if (id != tipoQuarto.IdtipoQuarto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoQuarto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoQuartoExists(tipoQuarto.IdtipoQuarto))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", tipoQuarto.Idhotel);
            return View(tipoQuarto);
        }

        // GET: TipoQuartoes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoQuarto = await _context.TipoQuarto
                .Include(t => t.IdhotelNavigation)
                .FirstOrDefaultAsync(m => m.IdtipoQuarto == id);
            if (tipoQuarto == null)
            {
                return NotFound();
            }

            return View(tipoQuarto);
        }

        // POST: TipoQuartoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var tipoQuarto = await _context.TipoQuarto.FindAsync(id);
            _context.TipoQuarto.Remove(tipoQuarto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoQuartoExists(long id)
        {
            return _context.TipoQuarto.Any(e => e.IdtipoQuarto == id);
        }
    }
}
