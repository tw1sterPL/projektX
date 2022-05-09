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

namespace KoloTumak.Intranet.Controllers
{
    public class EditWWWsController : Controller
    {
        private readonly KoloTumakContext _context;

        public EditWWWsController(KoloTumakContext context)
        {
            _context = context;
        }

        // GET: EditWWWs
        public async Task<IActionResult> Index()
        {
            return View(await _context.EditWWW.ToListAsync());
        }

        // GET: EditWWWs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editWWW = await _context.EditWWW
                .FirstOrDefaultAsync(m => m.IdPosition == id);
            if (editWWW == null)
            {
                return NotFound();
            }

            return View(editWWW);
        }

        // GET: EditWWWs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EditWWWs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPosition,NameNavSite,NameSite,NameSiteHeader")] EditWWW editWWW)
        {
            if (ModelState.IsValid)
            {
                _context.Add(editWWW);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(editWWW);
        }

        // GET: EditWWWs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editWWW = await _context.EditWWW.FindAsync(id);
            if (editWWW == null)
            {
                return NotFound();
            }
            return View(editWWW);
        }

        // POST: EditWWWs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPosition,NameNavSite,NameSite,NameSiteHeader")] EditWWW editWWW)
        {
            if (id != editWWW.IdPosition)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editWWW);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EditWWWExists(editWWW.IdPosition))
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
            return View(editWWW);
        }

        // GET: EditWWWs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editWWW = await _context.EditWWW
                .FirstOrDefaultAsync(m => m.IdPosition == id);
            if (editWWW == null)
            {
                return NotFound();
            }

            return View(editWWW);
        }

        // POST: EditWWWs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var editWWW = await _context.EditWWW.FindAsync(id);
            _context.EditWWW.Remove(editWWW);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EditWWWExists(int id)
        {
            return _context.EditWWW.Any(e => e.IdPosition == id);
        }
    }
}
