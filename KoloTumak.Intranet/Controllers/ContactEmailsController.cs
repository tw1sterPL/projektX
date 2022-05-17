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
    public class ContactEmailsController : Controller
    {
        private readonly KoloTumakContext _context;

        public ContactEmailsController(KoloTumakContext context)
        {
            _context = context;
        }

        // GET: ContactEmails
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactEmail.ToListAsync());
        }

        // GET: ContactEmails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ContactEmail == null)
            {
                return NotFound();
            }

            var contactEmail = await _context.ContactEmail
                .FirstOrDefaultAsync(m => m.IdPosition == id);
            if (contactEmail == null)
            {
                return NotFound();
            }

            return View(contactEmail);
        }

        // GET: ContactEmails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactEmails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPosition,NameTextEmail,Email")] ContactEmail contactEmail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactEmail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactEmail);
        }

        // GET: ContactEmails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ContactEmail == null)
            {
                return NotFound();
            }

            var contactEmail = await _context.ContactEmail.FindAsync(id);
            if (contactEmail == null)
            {
                return NotFound();
            }
            return View(contactEmail);
        }

        // POST: ContactEmails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPosition,NameTextEmail,Email")] ContactEmail contactEmail)
        {
            if (id != contactEmail.IdPosition)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactEmail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactEmailExists(contactEmail.IdPosition))
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
            return View(contactEmail);
        }

        // GET: ContactEmails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ContactEmail == null)
            {
                return NotFound();
            }

            var contactEmail = await _context.ContactEmail
                .FirstOrDefaultAsync(m => m.IdPosition == id);
            if (contactEmail == null)
            {
                return NotFound();
            }

            return View(contactEmail);
        }

        // POST: ContactEmails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ContactEmail == null)
            {
                return Problem("Entity set 'KoloTumakContext.ContactEmail'  is null.");
            }
            var contactEmail = await _context.ContactEmail.FindAsync(id);
            if (contactEmail != null)
            {
                _context.ContactEmail.Remove(contactEmail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactEmailExists(int id)
        {
          return (_context.ContactEmail?.Any(e => e.IdPosition == id)).GetValueOrDefault();
        }
    }
}
