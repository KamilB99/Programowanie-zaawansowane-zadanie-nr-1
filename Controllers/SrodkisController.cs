using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdvancedProgramming_Lesson1.Data;
using AdvancedProgramming_Lesson1.Models;

namespace AdvancedProgramming_Lesson1.Controllers
{
    public class SrodkisController : Controller
    {
        private readonly MvcSrodkiContext _context;

        public SrodkisController(MvcSrodkiContext context)
        {
            _context = context;
        }

        // GET: Srodkis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Srodki.ToListAsync());
        }

        // GET: Srodkis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var srodki = await _context.Srodki
                .FirstOrDefaultAsync(m => m.Id == id);
            if (srodki == null)
            {
                return NotFound();
            }

            return View(srodki);
        }

        // GET: Srodkis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Srodkis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Rodzaj_srodka,Producent,Cena,Data_waznosci,Pojemnosc")] Srodki srodki)
        {
            if (ModelState.IsValid)
            {
                _context.Add(srodki);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(srodki);
        }

        // GET: Srodkis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var srodki = await _context.Srodki.FindAsync(id);
            if (srodki == null)
            {
                return NotFound();
            }
            return View(srodki);
        }

        // POST: Srodkis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Rodzaj_srodka,Producent,Cena,Data_waznosci,Pojemnosc")] Srodki srodki)
        {
            if (id != srodki.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(srodki);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SrodkiExists(srodki.Id))
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
            return View(srodki);
        }

        // GET: Srodkis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var srodki = await _context.Srodki
                .FirstOrDefaultAsync(m => m.Id == id);
            if (srodki == null)
            {
                return NotFound();
            }

            return View(srodki);
        }

        // POST: Srodkis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var srodki = await _context.Srodki.FindAsync(id);
            _context.Srodki.Remove(srodki);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SrodkiExists(int id)
        {
            return _context.Srodki.Any(e => e.Id == id);
        }
    }
}
