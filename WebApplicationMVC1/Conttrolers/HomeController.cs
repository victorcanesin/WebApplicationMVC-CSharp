using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationMVC1.Models;
using WebApplicationMVC1.Repositories;

namespace WebApplicationMVC1.Conttrolers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
