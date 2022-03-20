using KoloTumak.Intranet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KoloTumak.Intranet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Start()
        {
            return View();
        }
        public IActionResult Book()
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }
        public IActionResult HuntersList()
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