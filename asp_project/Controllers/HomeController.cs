using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        GetDBtoAPI getDB = new GetDBtoAPI();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginSuccess()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetTodayDB()
        {
            getDB.GetSeoul(DateTime.Now);
            getDB.GetPolice(DateTime.Now, DateTime.Now, 1000);
            Response.Redirect("Index");
            return View();
        }

        public IActionResult GetDB()
        {
            getDB.GetSeoul(DateTime.Now);
            getDB.GetPolice(new DateTime(2020,01,01),DateTime.Now, 10000);

            Response.Redirect("Index");
            return View();
        }
    }
}
