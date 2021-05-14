using Microsoft.AspNetCore.Mvc;

namespace PieOpticon.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}