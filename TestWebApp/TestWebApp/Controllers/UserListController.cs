using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.Controllers
{
    public class UserListController: Controller
    {
        private const IConfiguration config;
        public UserListController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
