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
    public class ReservasController : Controller
    {
        private readonly BookingContext _context;

        public ReservasController(BookingContext context)
        {
            _context = context;
        }

        // GET: Reservas
        public async Task<IActionResult> Index()
        {
            var bookingContext = _context.Reservas.Include(r => r.CodPagamentoNavigation).Include(r => r.IdclienteNavigation).Include(r => r.IdhotelNavigation).Include(r => r.IdregimeNavigation).Include(r => r.IdtipoQuartoNavigation);
            return View(await bookingContext.ToListAsync());
        }

        // GET: Reservas/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservas = await _context.Reservas
                .Include(r => r.CodPagamentoNavigation)
                .Include(r => r.IdclienteNavigation)
                .Include(r => r.IdhotelNavigation)
                .Include(r => r.IdregimeNavigation)
                .Include(r => r.IdtipoQuartoNavigation)
                .FirstOrDefaultAsync(m => m.Idreserva == id);
            if (reservas == null)
            {
                return NotFound();
            }

            return View(reservas);
        }

        // GET: Reservas/Create
        public IActionResult Create()
        {
            ViewData["CodPagamento"] = new SelectList(_context.Pagamento, "CodPagamento", "DataValidadeCartao");
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Idcliente", "Cc");
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal");
            ViewData["Idregime"] = new SelectList(_context.Regimes, "Idregime", "TipoRegime");
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao");
            return View();
        }

        // POST: Reservas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idreserva,Idhotel,Idcliente,Idregime,IdtipoQuarto,CodPagamento,QuantAdultos,QuantCriancas,CheckIn,CheckOut")] Reservas reservas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodPagamento"] = new SelectList(_context.Pagamento, "CodPagamento", "DataValidadeCartao", reservas.CodPagamento);
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Idcliente", "Cc", reservas.Idcliente);
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", reservas.Idhotel);
            ViewData["Idregime"] = new SelectList(_context.Regimes, "Idregime", "TipoRegime", reservas.Idregime);
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao", reservas.IdtipoQuarto);
            return View(reservas);
        }

        // GET: Reservas/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservas = await _context.Reservas.FindAsync(id);
            if (reservas == null)
            {
                return NotFound();
            }
            ViewData["CodPagamento"] = new SelectList(_context.Pagamento, "CodPagamento", "DataValidadeCartao", reservas.CodPagamento);
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Idcliente", "Cc", reservas.Idcliente);
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", reservas.Idhotel);
            ViewData["Idregime"] = new SelectList(_context.Regimes, "Idregime", "TipoRegime", reservas.Idregime);
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao", reservas.IdtipoQuarto);
            return View(reservas);
        }

        // POST: Reservas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Idreserva,Idhotel,Idcliente,Idregime,IdtipoQuarto,CodPagamento,QuantAdultos,QuantCriancas,CheckIn,CheckOut")] Reservas reservas)
        {
            if (id != reservas.Idreserva)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservasExists(reservas.Idreserva))
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
            ViewData["CodPagamento"] = new SelectList(_context.Pagamento, "CodPagamento", "DataValidadeCartao", reservas.CodPagamento);
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Idcliente", "Cc", reservas.Idcliente);
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", reservas.Idhotel);
            ViewData["Idregime"] = new SelectList(_context.Regimes, "Idregime", "TipoRegime", reservas.Idregime);
            ViewData["IdtipoQuarto"] = new SelectList(_context.TipoQuarto, "IdtipoQuarto", "Descricao", reservas.IdtipoQuarto);
            return View(reservas);
        }

        // GET: Reservas/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservas = await _context.Reservas
                .Include(r => r.CodPagamentoNavigation)
                .Include(r => r.IdclienteNavigation)
                .Include(r => r.IdhotelNavigation)
                .Include(r => r.IdregimeNavigation)
                .Include(r => r.IdtipoQuartoNavigation)
                .FirstOrDefaultAsync(m => m.Idreserva == id);
            if (reservas == null)
            {
                return NotFound();
            }

            return View(reservas);
        }

        // POST: Reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var reservas = await _context.Reservas.FindAsync(id);
            _context.Reservas.Remove(reservas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservasExists(long id)
        {
            return _context.Reservas.Any(e => e.Idreserva == id);
        }
    }
}
