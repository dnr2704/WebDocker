using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webdocker.Models;

namespace webdocker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            string a = string.Empty;
            string b = string.Empty;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
