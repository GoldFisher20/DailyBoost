using System.Diagnostics;
using DailyBoost.Models;
using Microsoft.AspNetCore.Mvc;

namespace DailyBoost.Controllers
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

    }
}
