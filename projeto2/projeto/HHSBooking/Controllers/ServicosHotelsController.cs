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
    public class ServicosHotelsController : Controller
    {
        private readonly BookingContext _context;

        public ServicosHotelsController(BookingContext context)
        {
            _context = context;
        }

        // GET: ServicosHotels
        public async Task<IActionResult> Index()
        {
            var bookingContext = _context.ServicosHotel.Include(s => s.IdhotelNavigation);
            return View(await bookingContext.ToListAsync());
        }

        // GET: ServicosHotels/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicosHotel = await _context.ServicosHotel
                .Include(s => s.IdhotelNavigation)
                .FirstOrDefaultAsync(m => m.Idservicos == id);
            if (servicosHotel == null)
            {
                return NotFound();
            }

            return View(servicosHotel);
        }

        // GET: ServicosHotels/Create
        public IActionResult Create()
        {
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal");
            return View();
        }

        // POST: ServicosHotels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idservicos,Idhotel,Descricao")] ServicosHotel servicosHotel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servicosHotel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", servicosHotel.Idhotel);
            return View(servicosHotel);
        }

        // GET: ServicosHotels/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicosHotel = await _context.ServicosHotel.FindAsync(id);
            if (servicosHotel == null)
            {
                return NotFound();
            }
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", servicosHotel.Idhotel);
            return View(servicosHotel);
        }

        // POST: ServicosHotels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("Idservicos,Idhotel,Descricao")] ServicosHotel servicosHotel)
        {
            if (id != servicosHotel.Idservicos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicosHotel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicosHotelExists(servicosHotel.Idservicos))
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
            ViewData["Idhotel"] = new SelectList(_context.Hoteis, "Idhotel", "CodPostal", servicosHotel.Idhotel);
            return View(servicosHotel);
        }

        // GET: ServicosHotels/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicosHotel = await _context.ServicosHotel
                .Include(s => s.IdhotelNavigation)
                .FirstOrDefaultAsync(m => m.Idservicos == id);
            if (servicosHotel == null)
            {
                return NotFound();
            }

            return View(servicosHotel);
        }

        // POST: ServicosHotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var servicosHotel = await _context.ServicosHotel.FindAsync(id);
            _context.ServicosHotel.Remove(servicosHotel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicosHotelExists(short id)
        {
            return _context.ServicosHotel.Any(e => e.Idservicos == id);
        }
    }
}
