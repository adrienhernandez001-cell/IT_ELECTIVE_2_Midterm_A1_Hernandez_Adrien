using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_Midterm_A1_Hernandez_Adrien.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Adrien Hernandez";
            return View();
        }

        public IActionResult About()
        {
            ViewData["About"] = "I am an IT student passionate about software and web development.";
            return View();
        }

        public IActionResult Skills()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}