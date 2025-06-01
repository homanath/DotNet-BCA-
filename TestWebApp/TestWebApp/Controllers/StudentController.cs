using Microsoft.AspNetCore.Mvc;
using TestWebApp.Models;
using Microsoft.Data.SqlClient;

namespace TestWebApp.Controllers
{
    public class StudentController(IConfiguration config) : Controller
    {
        private readonly IConfiguration _config = config;
        public IActionResult Index()
        {
            List<Student> list = new List<Student>();
            string conString = _config.GetConnectionString("Conn");
            SqlConnection conn = new SqlConnection(conString);

          return View(list);
        }
    }
}
    

