#nullable disable
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
    public class HeaderSiteNamesController : Controller
    {
        private readonly KoloTumakContext _context;

        public HeaderSiteNamesController(KoloTumakContext context)
        {
            _context = context;
        }

        // GET: HeaderSiteNames
        public async Task<IActionResult> Index()
        {
            return View(await _context.HeaderSiteName.ToListAsync());
        }

        // GET: HeaderSiteNames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var headerSiteName = await _context.HeaderSiteName
                .FirstOrDefaultAsync(m => m.IdSiteHeader == id);
            if (headerSiteName == null)
            {
                return NotFound();
            }

            return View(headerSiteName);
        }

        // GET: HeaderSiteNames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HeaderSiteNames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSiteHeader,NameSiteHeader")] HeaderSiteName headerSiteName)
        {
            if (ModelState.IsValid)
            {
                _context.Add(headerSiteName);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(headerSiteName);
        }

        // GET: HeaderSiteNames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var headerSiteName = await _context.HeaderSiteName.FindAsync(id);
            if (headerSiteName == null)
            {
                return NotFound();
            }
            return View(headerSiteName);
        }

        // POST: HeaderSiteNames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSiteHeader,NameSiteHeader")] HeaderSiteName headerSiteName)
        {
            if (id != headerSiteName.IdSiteHeader)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(headerSiteName);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeaderSiteNameExists(headerSiteName.IdSiteHeader))
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
            return View(headerSiteName);
        }

        // GET: HeaderSiteNames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var headerSiteName = await _context.HeaderSiteName
                .FirstOrDefaultAsync(m => m.IdSiteHeader == id);
            if (headerSiteName == null)
            {
                return NotFound();
            }

            return View(headerSiteName);
        }

        // POST: HeaderSiteNames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var headerSiteName = await _context.HeaderSiteName.FindAsync(id);
            _context.HeaderSiteName.Remove(headerSiteName);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeaderSiteNameExists(int id)
        {
            return _context.HeaderSiteName.Any(e => e.IdSiteHeader == id);
        }
    }
}
