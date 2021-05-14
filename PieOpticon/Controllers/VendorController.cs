using Microsoft.AspNetCore.Mvc;
using PieOpticon.Models;

namespace PieOpticon.Controllers
{
  public class VendorController : Controller
  {
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor thisVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

  }
}