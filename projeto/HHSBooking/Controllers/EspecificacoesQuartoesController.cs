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
    public class EspecificacoesQuartoesController : Controller
    {
        private readonly BookingContext _context;

        public EspecificacoesQuartoesController(BookingContext context)
        {
            _context = context;
        }

        // GET: EspecificacoesQuartoes
        public async Task<IActionResult> Index()
        {
            var bookingContext = _context.EspecificacoesQuarto.Include(e => e.IdtipoQuartoNavigation);
            return View(await bookingContext.ToListAsync());
        }

        // GET: EspecificacoesQuartoes/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especificacoesQuarto = await _context.EspecificacoesQuarto
                .Include(e => e.IdtipoQuartoNavigation)
                .FirstOrDefaultAsync(m => m.Idespecificacao == id);
            if (especificacoesQuarto == null)
            {
                return NotFound();
            }

            return View(especificacoesQuarto);
        }

        // GET: EspecificacoesQuartoes/Create
        public IActionResult Create()
        {
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao");
            return View();
        }

        // POST: EspecificacoesQuartoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idespecificacao,IdtipoQuarto,Descricao")] EspecificacoesQuarto especificacoesQuarto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(especificacoesQuarto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao", especificacoesQuarto.IdtipoQuarto);
            return View(especificacoesQuarto);
        }

        // GET: EspecificacoesQuartoes/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especificacoesQuarto = await _context.EspecificacoesQuarto.FindAsync(id);
            if (especificacoesQuarto == null)
            {
                return NotFound();
            }
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao", especificacoesQuarto.IdtipoQuarto);
            return View(especificacoesQuarto);
        }

        // POST: EspecificacoesQuartoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("Idespecificacao,IdtipoQuarto,Descricao")] EspecificacoesQuarto especificacoesQuarto)
        {
            if (id != especificacoesQuarto.Idespecificacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(especificacoesQuarto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspecificacoesQuartoExists(especificacoesQuarto.Idespecificacao))
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
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao", especificacoesQuarto.IdtipoQuarto);
            return View(especificacoesQuarto);
        }

        // GET: EspecificacoesQuartoes/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especificacoesQuarto = await _context.EspecificacoesQuarto
                .Include(e => e.IdtipoQuartoNavigation)
                .FirstOrDefaultAsync(m => m.Idespecificacao == id);
            if (especificacoesQuarto == null)
            {
                return NotFound();
            }

            return View(especificacoesQuarto);
        }

        // POST: EspecificacoesQuartoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var especificacoesQuarto = await _context.EspecificacoesQuarto.FindAsync(id);
            _context.EspecificacoesQuarto.Remove(especificacoesQuarto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspecificacoesQuartoExists(short id)
        {
            return _context.EspecificacoesQuarto.Any(e => e.Idespecificacao == id);
        }
    }
}
