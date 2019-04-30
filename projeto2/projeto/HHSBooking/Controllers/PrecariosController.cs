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
    public class PrecariosController : Controller
    {
        private readonly BookingContext _context;

        public PrecariosController(BookingContext context)
        {
            _context = context;
        }

        // GET: Precarios
        public async Task<IActionResult> Index()
        {
            var bookingContext = _context.Precario.Include(p => p.IdregimeNavigation).Include(p => p.IdtipoQuartoNavigation);
            return View(await bookingContext.ToListAsync());
        }

        // GET: Precarios/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var precario = await _context.Precario
                .Include(p => p.IdregimeNavigation)
                .Include(p => p.IdtipoQuartoNavigation)
                .FirstOrDefaultAsync(m => m.Idregime == id);
            if (precario == null)
            {
                return NotFound();
            }

            return View(precario);
        }

        // GET: Precarios/Create
        public IActionResult Create()
        {
            ViewData["Idregime"] = new SelectList(_context.Regimes, "Idregime", "TipoRegime");
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao");
            return View();
        }

        // POST: Precarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idregime,IdtipoQuarto,Data,Preco")] Precario precario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(precario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idregime"] = new SelectList(_context.Regimes, "Idregime", "TipoRegime", precario.Idregime);
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao", precario.IdtipoQuarto);
            return View(precario);
        }

        // GET: Precarios/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var precario = await _context.Precario.FindAsync(id);
            if (precario == null)
            {
                return NotFound();
            }
            ViewData["Idregime"] = new SelectList(_context.Regimes, "Idregime", "TipoRegime", precario.Idregime);
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao", precario.IdtipoQuarto);
            return View(precario);
        }

        // POST: Precarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("Idregime,IdtipoQuarto,Data,Preco")] Precario precario)
        {
            if (id != precario.Idregime)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(precario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrecarioExists(precario.Idregime))
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
            ViewData["Idregime"] = new SelectList(_context.Regimes, "Idregime", "TipoRegime", precario.Idregime);
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao", precario.IdtipoQuarto);
            return View(precario);
        }

        // GET: Precarios/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var precario = await _context.Precario
                .Include(p => p.IdregimeNavigation)
                .Include(p => p.IdtipoQuartoNavigation)
                .FirstOrDefaultAsync(m => m.Idregime == id);
            if (precario == null)
            {
                return NotFound();
            }

            return View(precario);
        }

        // POST: Precarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var precario = await _context.Precario.FindAsync(id);
            _context.Precario.Remove(precario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrecarioExists(byte id)
        {
            return _context.Precario.Any(e => e.Idregime == id);
        }
    }
}
