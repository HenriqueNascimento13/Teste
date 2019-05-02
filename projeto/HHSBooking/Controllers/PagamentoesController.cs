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
    public class PagamentoesController : Controller
    {
        private readonly BookingContext _context;

        public PagamentoesController(BookingContext context)
        {
            _context = context;
        }

        // GET: Pagamentoes
        public async Task<IActionResult> Index()
        {
            var bookingContext = _context.Pagamento.Include(p => p.IdtipoPagamentoNavigation);
            return View(await bookingContext.ToListAsync());
        }

        // GET: Pagamentoes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamento = await _context.Pagamento
                .Include(p => p.IdtipoPagamentoNavigation)
                .FirstOrDefaultAsync(m => m.CodPagamento == id);
            if (pagamento == null)
            {
                return NotFound();
            }

            return View(pagamento);
        }

        // GET: Pagamentoes/Create
        public IActionResult Create()
        {
            ViewData["IdtipoPagamento"] = new SelectList(_context.TipoPagamento, "IdtipoPagamento", "Designacao");
            return View();
        }

        // POST: Pagamentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodPagamento,IdtipoPagamento,NomeTitular,NumCartao,DataValidadeCartao,Cvv,Descricao")] Pagamento pagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdtipoPagamento"] = new SelectList(_context.TipoPagamento, "IdtipoPagamento", "Designacao", pagamento.IdtipoPagamento);
            return View(pagamento);
        }

        // GET: Pagamentoes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamento = await _context.Pagamento.FindAsync(id);
            if (pagamento == null)
            {
                return NotFound();
            }
            ViewData["IdtipoPagamento"] = new SelectList(_context.TipoPagamento, "IdtipoPagamento", "Designacao", pagamento.IdtipoPagamento);
            return View(pagamento);
        }

        // POST: Pagamentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("CodPagamento,IdtipoPagamento,NomeTitular,NumCartao,DataValidadeCartao,Cvv,Descricao")] Pagamento pagamento)
        {
            if (id != pagamento.CodPagamento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PagamentoExists(pagamento.CodPagamento))
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
            ViewData["IdtipoPagamento"] = new SelectList(_context.TipoPagamento, "IdtipoPagamento", "Designacao", pagamento.IdtipoPagamento);
            return View(pagamento);
        }

        // GET: Pagamentoes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamento = await _context.Pagamento
                .Include(p => p.IdtipoPagamentoNavigation)
                .FirstOrDefaultAsync(m => m.CodPagamento == id);
            if (pagamento == null)
            {
                return NotFound();
            }

            return View(pagamento);
        }

        // POST: Pagamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var pagamento = await _context.Pagamento.FindAsync(id);
            _context.Pagamento.Remove(pagamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PagamentoExists(long id)
        {
            return _context.Pagamento.Any(e => e.CodPagamento == id);
        }
    }
}
