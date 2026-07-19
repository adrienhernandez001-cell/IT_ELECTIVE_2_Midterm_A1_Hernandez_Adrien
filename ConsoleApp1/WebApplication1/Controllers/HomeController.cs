using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_Midterm_A1_Hernandez_Adrien.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            ViewData["Name"] = "Adrien Hernandez";
            ViewData["Role"] = "Aspiring IT Professional";

            ViewData["Intro"] =
                "Hello! I am currently pursuing a Bachelor of Science in Information Technology. I have a passion for technology, problem-solving, and continuously learning new skills. I enjoy exploring web development, databases, networking, and system administration.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About";

            ViewData["About1"] =
                "I am currently pursuing a Bachelor of Science in Information Technology. I have a strong passion for technology and enjoy learning different areas of IT including web development, databases, networking, and system administration.";

            ViewData["About2"] =
                "My goal is to become a Professional IT Specialist who can contribute to innovative technology solutions while continuously learning and adapting to new technologies.";

            return View();
        }

        public IActionResult Skills()
        {
            ViewData["Title"] = "Skills";
            return View();
        }

        public IActionResult Projects()
        {
            ViewData["Title"] = "Projects";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";
            return View();
        }
    }
}