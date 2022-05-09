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

        public IActionResult Index()
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
            return View();
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}