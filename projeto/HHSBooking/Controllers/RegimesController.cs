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
    public class RegimesController : Controller
    {
        private readonly BookingContext _context;

        public RegimesController(BookingContext context)
        {
            _context = context;
        }

        // GET: Regimes
        public async Task<IActionResult> Index()
        {
            var bookingContext = _context.Regimes.Include(r => r.IdhotelNavigation);
            return View(await bookingContext.ToListAsync());
        }

        // GET: Regimes/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regimes = await _context.Regimes
                .Include(r => r.IdhotelNavigation)
                .FirstOrDefaultAsync(m => m.Idregime == id);
            if (regimes == null)
            {
                return NotFound();
            }

            return View(regimes);
        }

        // GET: Regimes/Create
        public IActionResult Create()
        {
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal");
            return View();
        }

        // POST: Regimes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idregime,Idhotel,TipoRegime")] Regimes regimes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(regimes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", regimes.Idhotel);
            return View(regimes);
        }

        // GET: Regimes/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regimes = await _context.Regimes.FindAsync(id);
            if (regimes == null)
            {
                return NotFound();
            }
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", regimes.Idhotel);
            return View(regimes);
        }

        // POST: Regimes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("Idregime,Idhotel,TipoRegime")] Regimes regimes)
        {
            if (id != regimes.Idregime)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(regimes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegimesExists(regimes.Idregime))
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
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", regimes.Idhotel);
            return View(regimes);
        }

        // GET: Regimes/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regimes = await _context.Regimes
                .Include(r => r.IdhotelNavigation)
                .FirstOrDefaultAsync(m => m.Idregime == id);
            if (regimes == null)
            {
                return NotFound();
            }

            return View(regimes);
        }

        // POST: Regimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var regimes = await _context.Regimes.FindAsync(id);
            _context.Regimes.Remove(regimes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegimesExists(byte id)
        {
            return _context.Regimes.Any(e => e.Idregime == id);
        }
    }
}
