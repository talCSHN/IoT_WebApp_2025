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
    public class DivController : Controller
    {
        private readonly BookrentalshopContext _context;

        public DivController(BookrentalshopContext context)
        {
            _context = context;
        }

        // GET: Div
        public async Task<IActionResult> Index()
        {
            return View(await _context.Divtbls.ToListAsync());
        }

        // GET: Div/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divtbl = await _context.Divtbls
                .FirstOrDefaultAsync(m => m.Division == id);
            if (divtbl == null)
            {
                return NotFound();
            }

            return View(divtbl);
        }

        // GET: Div/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Div/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Division,Names")] Divtbl divtbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(divtbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(divtbl);
        }

        // GET: Div/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divtbl = await _context.Divtbls.FindAsync(id);
            if (divtbl == null)
            {
                return NotFound();
            }
            return View(divtbl);
        }

        // POST: Div/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Division,Names")] Divtbl divtbl)
        {
            if (id != divtbl.Division)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(divtbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DivtblExists(divtbl.Division))
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
            return View(divtbl);
        }

        // GET: Div/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divtbl = await _context.Divtbls
                .FirstOrDefaultAsync(m => m.Division == id);
            if (divtbl == null)
            {
                return NotFound();
            }

            return View(divtbl);
        }

        // POST: Div/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var divtbl = await _context.Divtbls.FindAsync(id);
            if (divtbl != null)
            {
                _context.Divtbls.Remove(divtbl);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DivtblExists(string id)
        {
            return _context.Divtbls.Any(e => e.Division == id);
        }
    }
}
