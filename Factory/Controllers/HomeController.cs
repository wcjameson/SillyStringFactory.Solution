using Microsoft.AspNetCore.Mvc;

namespace SillyStringFactory.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}