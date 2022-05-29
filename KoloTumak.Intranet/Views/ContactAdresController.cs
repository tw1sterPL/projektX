using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KoloTumak.Data.Data;
using KoloTumak.Data.Data.CMS;

namespace KoloTumak.Intranet.Views
{
    public class ContactAdresController : Controller
    {
        private readonly KoloTumakContext _context;

        public ContactAdresController(KoloTumakContext context)
        {
            _context = context;
        }

        // GET: ContactAdres
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactAdres.ToListAsync());
        }

        // GET: ContactAdres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ContactAdres == null)
            {
                return NotFound();
            }

            var contactAdres = await _context.ContactAdres
                .FirstOrDefaultAsync(m => m.IdPosition == id);
            if (contactAdres == null)
            {
                return NotFound();
            }

            return View(contactAdres);
        }

        // GET: ContactAdres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactAdres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPosition,NameTextAdres,Adres")] ContactAdres contactAdres)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactAdres);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactAdres);
        }

        // GET: ContactAdres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ContactAdres == null)
            {
                return NotFound();
            }

            var contactAdres = await _context.ContactAdres.FindAsync(id);
            if (contactAdres == null)
            {
                return NotFound();
            }
            return View(contactAdres);
        }

        // POST: ContactAdres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPosition,NameTextAdres,Adres")] ContactAdres contactAdres)
        {
            if (id != contactAdres.IdPosition)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactAdres);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactAdresExists(contactAdres.IdPosition))
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
            return View(contactAdres);
        }

        // GET: ContactAdres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ContactAdres == null)
            {
                return NotFound();
            }

            var contactAdres = await _context.ContactAdres
                .FirstOrDefaultAsync(m => m.IdPosition == id);
            if (contactAdres == null)
            {
                return NotFound();
            }

            return View(contactAdres);
        }

        // POST: ContactAdres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ContactAdres == null)
            {
                return Problem("Entity set 'KoloTumakContext.ContactAdres'  is null.");
            }
            var contactAdres = await _context.ContactAdres.FindAsync(id);
            if (contactAdres != null)
            {
                _context.ContactAdres.Remove(contactAdres);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactAdresExists(int id)
        {
            return (_context.ContactAdres?.Any(e => e.IdPosition == id)).GetValueOrDefault();
        }
    }
}
