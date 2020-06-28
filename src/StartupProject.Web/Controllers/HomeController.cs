using Microsoft.AspNetCore.Mvc;

namespace StartupProject.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
