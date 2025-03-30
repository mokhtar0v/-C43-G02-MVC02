using Microsoft.AspNetCore.Mvc;

namespace Session2_MVC.Controllers
{
    public class MoviesController : Controller
    {
        //action == public, nonstatic method inside the controller
        //to excute any action => baseurl+controllername+actionname/?

        public string Index(int ID)
        {
            return $"Hello, {ID}";
        }
        public IActionResult GetMovie(int? ID,string name)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Movie    {ID}</br>{name}";

            //result.ContentType = "text/html";

            //result.StatusCode = 900;

            //return Content($"Movie    {ID}</br>{name}", "text/html");

            if (ID == 0) return BadRequest();

            else if (ID < 10) return NotFound();

            else return Content($"Movie    {ID}</br>{name}", "text/html");

        }

        public IActionResult TestRedirectAction()
        {
            return Redirect("https://www.csharp.com/article/action-result-in-asp-net-mvc/?srsltid=AfmBOooHhfTah4oZzfaJS1SvwBhhiLz8j7Pk8OAK3ezgVgUgX9YUeuog");
        }
        public IActionResult TestRedirectToGetMovies()
        {
            return RedirectToAction("GetMovie","Movies", new {ID = 30, name = "Marvel"});
        }
    }
}
