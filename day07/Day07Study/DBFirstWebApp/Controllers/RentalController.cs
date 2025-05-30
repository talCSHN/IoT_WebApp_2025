using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DbFirstWebApp.Models;

namespace DbFirstWebApp.Controllers
{
    public class RentalController : Controller
    {
        private readonly BookrentalshopContext _context;

        public RentalController(BookrentalshopContext context)
        {
            _context = context;
        }

        // GET: Rental
        public async Task<IActionResult> Index()
        {
            var bookrentalshopContext = _context.Rentaltbls.Include(r => r.BookIdxNavigation).Include(r => r.MemberIdxNavigation);
            return View(await bookrentalshopContext.ToListAsync());
        }

        // GET: Rental/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentaltbl = await _context.Rentaltbls
                .Include(r => r.BookIdxNavigation)
                .Include(r => r.MemberIdxNavigation)
                .FirstOrDefaultAsync(m => m.Idx == id);
            if (rentaltbl == null)
            {
                return NotFound();
            }

            return View(rentaltbl);
        }

        // GET: Rental/Create
        public IActionResult Create()
        {
            ViewData["BookIdx"] = new SelectList(_context.Bookstbls, "Idx", "Idx");
            ViewData["MemberIdx"] = new SelectList(_context.Membertbls, "Idx", "Idx");
            return View();
        }

        // POST: Rental/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idx,MemberIdx,BookIdx,RentalDate,ReturnDate")] Rentaltbl rentaltbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentaltbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookIdx"] = new SelectList(_context.Bookstbls, "Idx", "Idx", rentaltbl.BookIdx);
            ViewData["MemberIdx"] = new SelectList(_context.Membertbls, "Idx", "Idx", rentaltbl.MemberIdx);
            return View(rentaltbl);
        }

        // GET: Rental/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentaltbl = await _context.Rentaltbls.FindAsync(id);
            if (rentaltbl == null)
            {
                return NotFound();
            }
            ViewData["BookIdx"] = new SelectList(_context.Bookstbls, "Idx", "Idx", rentaltbl.BookIdx);
            ViewData["MemberIdx"] = new SelectList(_context.Membertbls, "Idx", "Idx", rentaltbl.MemberIdx);
            return View(rentaltbl);
        }

        // POST: Rental/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idx,MemberIdx,BookIdx,RentalDate,ReturnDate")] Rentaltbl rentaltbl)
        {
            if (id != rentaltbl.Idx)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentaltbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentaltblExists(rentaltbl.Idx))
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
            ViewData["BookIdx"] = new SelectList(_context.Bookstbls, "Idx", "Idx", rentaltbl.BookIdx);
            ViewData["MemberIdx"] = new SelectList(_context.Membertbls, "Idx", "Idx", rentaltbl.MemberIdx);
            return View(rentaltbl);
        }

        // GET: Rental/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentaltbl = await _context.Rentaltbls
                .Include(r => r.BookIdxNavigation)
                .Include(r => r.MemberIdxNavigation)
                .FirstOrDefaultAsync(m => m.Idx == id);
            if (rentaltbl == null)
            {
                return NotFound();
            }

            return View(rentaltbl);
        }

        // POST: Rental/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentaltbl = await _context.Rentaltbls.FindAsync(id);
            if (rentaltbl != null)
            {
                _context.Rentaltbls.Remove(rentaltbl);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentaltblExists(int id)
        {
            return _context.Rentaltbls.Any(e => e.Idx == id);
        }
    }
}
