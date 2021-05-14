using Microsoft.AspNetCore.Mvc;
using YOURPROJECT.Models;

namespace YOURPROJECT.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult HomePage()
    {
      return View();
    }
    // This is a *root path* (just "/", not e.g. "/form")
    // Whatever is in here will display when a user goes to localhost:5000/ (or https://www.yoursite.com/)
    // You'll want to set this to display something! It's the home page for your web site.
    // "ActionResult HomePage()" will point to HomePage.cshtml -- follow any consistent naming convention to have it point to any page

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/formresult")]
    public ActionResult FormResult(string htmlInput1, string htmlInput2)
    {
      TemplateVariable myTemplateVariable = new TemplateVariable();
      myTemplateVariable.ParsedHtmlInput1 = htmlInput1;
      myTemplateVariable.ParsedHtmlInput2 = htmlInput2;
      return View(myTemplateVariable);
    }
  }
}