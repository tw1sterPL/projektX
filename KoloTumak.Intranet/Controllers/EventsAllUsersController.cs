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
    public class EventsAllUsersController : Controller
    {
        private readonly KoloTumakIntranetContext _context;

        public EventsAllUsersController(KoloTumakIntranetContext context)
        {
            _context = context;
        }

        // GET: EventsAllUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.EventsAllUser.ToListAsync());
        }

        // GET: EventsAllUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventsAllUser = await _context.EventsAllUser
                .FirstOrDefaultAsync(m => m.IdEvents == id);
            if (eventsAllUser == null)
            {
                return NotFound();
            }

            return View(eventsAllUser);
        }

        // GET: EventsAllUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EventsAllUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEvents,DateStart,Type,Place,NameSurnameResponsiblePerson,Contact")] EventsAllUser eventsAllUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventsAllUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eventsAllUser);
        }

        // GET: EventsAllUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventsAllUser = await _context.EventsAllUser.FindAsync(id);
            if (eventsAllUser == null)
            {
                return NotFound();
            }
            return View(eventsAllUser);
        }

        // POST: EventsAllUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEvents,DateStart,Type,Place,NameSurnameResponsiblePerson,Contact")] EventsAllUser eventsAllUser)
        {
            if (id != eventsAllUser.IdEvents)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventsAllUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventsAllUserExists(eventsAllUser.IdEvents))
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
            return View(eventsAllUser);
        }

        // GET: EventsAllUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventsAllUser = await _context.EventsAllUser
                .FirstOrDefaultAsync(m => m.IdEvents == id);
            if (eventsAllUser == null)
            {
                return NotFound();
            }

            return View(eventsAllUser);
        }

        // POST: EventsAllUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventsAllUser = await _context.EventsAllUser.FindAsync(id);
            _context.EventsAllUser.Remove(eventsAllUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventsAllUserExists(int id)
        {
            return _context.EventsAllUser.Any(e => e.IdEvents == id);
        }
    }
}
