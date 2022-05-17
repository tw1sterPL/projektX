using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KoloTumak.Data.Data;
using KoloTumak.Data.Data.CMS;

namespace KoloTumak.Intranet.Controllers
{
    public class FooterWWWsController : Controller
    {
        private readonly KoloTumakContext _context;

        public FooterWWWsController(KoloTumakContext context)
        {
            _context = context;
        }

        // GET: FooterWWWs
        public async Task<IActionResult> Index()
        {
            return View(await _context.FooterWWW.ToListAsync());
        }

        // GET: FooterWWWs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FooterWWW == null)
            {
                return NotFound();
            }

            var footerWWW = await _context.FooterWWW
                .FirstOrDefaultAsync(m => m.IdPosition == id);
            if (footerWWW == null)
            {
                return NotFound();
            }

            return View(footerWWW);
        }

        // GET: FooterWWWs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FooterWWWs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPosition,NameFooter")] FooterWWW footerWWW)
        {
            if (ModelState.IsValid)
            {
                _context.Add(footerWWW);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(footerWWW);
        }

        // GET: FooterWWWs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FooterWWW == null)
            {
                return NotFound();
            }

            var footerWWW = await _context.FooterWWW.FindAsync(id);
            if (footerWWW == null)
            {
                return NotFound();
            }
            return View(footerWWW);
        }

        // POST: FooterWWWs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPosition,NameFooter")] FooterWWW footerWWW)
        {
            if (id != footerWWW.IdPosition)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(footerWWW);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FooterWWWExists(footerWWW.IdPosition))
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
            return View(footerWWW);
        }

        // GET: FooterWWWs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FooterWWW == null)
            {
                return NotFound();
            }

            var footerWWW = await _context.FooterWWW
                .FirstOrDefaultAsync(m => m.IdPosition == id);
            if (footerWWW == null)
            {
                return NotFound();
            }

            return View(footerWWW);
        }

        // POST: FooterWWWs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FooterWWW == null)
            {
                return Problem("Entity set 'KoloTumakContext.FooterWWW'  is null.");
            }
            var footerWWW = await _context.FooterWWW.FindAsync(id);
            if (footerWWW != null)
            {
                _context.FooterWWW.Remove(footerWWW);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FooterWWWExists(int id)
        {
          return (_context.FooterWWW?.Any(e => e.IdPosition == id)).GetValueOrDefault();
        }
    }
}
