using KoloTumak.Data.Data;
using Microsoft.AspNetCore.Mvc;
using ProjektX.Models;
using System.Diagnostics;

namespace ProjektX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KoloTumakContext _context;

        public HomeController(KoloTumakContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            ViewBag.ModelNavView =
                (
                 from editwww in _context.EditWWW
                 orderby editwww.IdPosition
                 select editwww
                ).ToList();

            ViewBag.ModelAbout =
               (
                from about in _context.About
                orderby about.IdAbout
                select about
               ).ToList();
            ViewBag.ModelManagement =
               (
                from management in _context.Management
                orderby management.IdManagement
                select management
               ).ToList();
            ViewBag.ModelHeaderSiteNames =
               (
                from header in _context.HeaderSiteName
                orderby header.IdSiteHeader
                select header
               ).ToList();
            ViewBag.ModelContactAdres =
                (
                 from contactAdres in _context.ContactAdres
                 orderby contactAdres.IdPosition
                 select contactAdres
                ).ToList();
            ViewBag.ModelContactEmail =
                (
                 from contactEmail in _context.ContactEmail
                 orderby contactEmail.IdPosition
                 select contactEmail
                 ).ToList();
            ViewBag.ModelContacts =
                (
                 from contact in _context.Contact
                 orderby contact.IdPosition
                 select contact
                ).ToList();
            ViewBag.ModelFooter =
                (
                 from footer in _context.FooterWWW
                 orderby footer.IdPosition
                 select footer
                ).ToList();
            if (id == null)
                id = _context.EditWWW.First().IdPosition;
            var item = _context.EditWWW.Find(id);

            return View(item);
        }

        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Management()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}