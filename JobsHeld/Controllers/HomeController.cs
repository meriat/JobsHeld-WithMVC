using Microsoft.AspNetCore.Mvc;

namespace JobsHeld.Controllers
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
