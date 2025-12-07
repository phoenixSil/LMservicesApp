using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using Mvc.Shopping.Client.Datas;
using Mvc.Shopping.Client.Models;

namespace Mvc.Shopping.Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(ProductContext.Products);
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
