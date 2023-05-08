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
    public class MeblesController : Controller
    {
        private readonly MvcMebleContext _context;

        public MeblesController(MvcMebleContext context)
        {
            _context = context;
        }

        // GET: Mebles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Meble.ToListAsync());
        }

        // GET: Mebles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meble = await _context.Meble
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meble == null)
            {
                return NotFound();
            }

            return View(meble);
        }

        // GET: Mebles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mebles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Material_wykonania,Waga,Kolor,Rodzaj_mebla,Cena")] Meble meble)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meble);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meble);
        }

        // GET: Mebles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meble = await _context.Meble.FindAsync(id);
            if (meble == null)
            {
                return NotFound();
            }
            return View(meble);
        }

        // POST: Mebles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Material_wykonania,Waga,Kolor,Rodzaj_mebla,Cena")] Meble meble)
        {
            if (id != meble.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meble);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MebleExists(meble.Id))
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
            return View(meble);
        }

        // GET: Mebles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meble = await _context.Meble
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meble == null)
            {
                return NotFound();
            }

            return View(meble);
        }

        // POST: Mebles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meble = await _context.Meble.FindAsync(id);
            _context.Meble.Remove(meble);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MebleExists(int id)
        {
            return _context.Meble.Any(e => e.Id == id);
        }
    }
}
