#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KoloTumak.Intranet.Data;
using KoloTumak.Intranet.Models.CMS;

namespace KoloTumak.Intranet.Controllers
{
    public class HuntersListsController : Controller
    {
        private readonly KoloTumakIntranetContext _context;

        public HuntersListsController(KoloTumakIntranetContext context)
        {
            _context = context;
        }

        // GET: HuntersLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.HuntersList.ToListAsync());
        }

        // GET: HuntersLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var huntersList = await _context.HuntersList
                .FirstOrDefaultAsync(m => m.IdHunters == id);
            if (huntersList == null)
            {
                return NotFound();
            }

            return View(huntersList);
        }

        // GET: HuntersLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HuntersLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHunters,Name,Surname,Type,Contact")] HuntersList huntersList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(huntersList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(huntersList);
        }

        // GET: HuntersLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var huntersList = await _context.HuntersList.FindAsync(id);
            if (huntersList == null)
            {
                return NotFound();
            }
            return View(huntersList);
        }

        // POST: HuntersLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdHunters,Name,Surname,Type,Contact")] HuntersList huntersList)
        {
            if (id != huntersList.IdHunters)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(huntersList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HuntersListExists(huntersList.IdHunters))
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
            return View(huntersList);
        }

        // GET: HuntersLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var huntersList = await _context.HuntersList
                .FirstOrDefaultAsync(m => m.IdHunters == id);
            if (huntersList == null)
            {
                return NotFound();
            }

            return View(huntersList);
        }

        // POST: HuntersLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var huntersList = await _context.HuntersList.FindAsync(id);
            _context.HuntersList.Remove(huntersList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HuntersListExists(int id)
        {
            return _context.HuntersList.Any(e => e.IdHunters == id);
        }
    }
}
