// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;

namespace MeuProjeto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return PhysicalFile("wwwroot/index.html", "text/html");
        }
    }
}
