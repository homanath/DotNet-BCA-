using Microsoft.AspNetCore.Mvc;

namespace MultiplyTable.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int num=1)
        {
            return View(num);
        }
    }
}
