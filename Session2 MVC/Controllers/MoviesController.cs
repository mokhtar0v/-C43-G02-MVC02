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
        public string GetMovie(int? ID)
        {

            if(ID is not null)
            return $"Movie    {ID}";

            return $"No Movie found";
        }
    }
}
