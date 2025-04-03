using Microsoft.AspNetCore.Mvc;

namespace Session2_MVC.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {
            return View(); //1st overload return View(); return view with the same name as the action
            //2nd overload return View(new Movie()); return view with the same name as the action and bind the model data to view
            //3rd overload return View("Omar"); return view with the same name as theprovided name
            //4th overload return View("Omar", new Movie()); 
        }
        public IActionResult Privacy()
        {
            return View();
            
        }
        public IActionResult About()
        {
            return View();
            
        }
        public IActionResult Contact()
        {
            return View();
            
        }
    }
}
