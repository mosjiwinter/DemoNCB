using DemoNCB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoNCB.Controllers
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
        public IActionResult Homemenu()
        {
            return View();
        }

        public IActionResult Report()
        {
            return View();
        }

        public IActionResult Uploadreview()
        {
            return View();
        }
        public IActionResult Downloadreport()
        {
            return View();
        }
        public IActionResult ExporttoNCB()
        {
            return View();
        }
       public IActionResult Importncb ()
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