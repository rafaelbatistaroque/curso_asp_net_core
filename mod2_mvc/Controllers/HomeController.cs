using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mod2_mvc.BD;
using mod2_mvc.Models;

namespace mod2_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices] Mod2DbContext context)
        { 
            ViewBag.ListaPaises = context.Paises.ToList();
            return View();
        }

        public IActionResult Privacy()
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
