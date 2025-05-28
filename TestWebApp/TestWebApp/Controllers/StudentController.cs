using Microsoft.AspNetCore.Mvc;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> list = new List<Student>
            {
                new Student() { Id = 101, Name = "Mohan", Address="Dharan", JoinDate=new DateOnly(2001, 09, 11)},

            };
          return View(list);
        }
    }
}
    

