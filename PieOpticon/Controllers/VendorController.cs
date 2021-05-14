using Microsoft.AspNetCore.Mvc;
using PieOpticon.Models;
using System.Collections.Generic;

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

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> vendorWithOrders = new Dictionary<string, object>();
      Vendor thisVendor = Vendor.Find(id);
      vendorWithOrders.Add("vendor", thisVendor);
      List<Order> theseOrders = thisVendor.Orders;
      vendorWithOrders.Add("orders", theseOrders);
      return View(vendorWithOrders);
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(string title, string date, int vendorId, int price)
    {
      Dictionary<string, object> vendorWithOrders = new Dictionary<string, object>();
      Vendor thisVendor = Vendor.Find(vendorId);
      vendorWithOrders.Add("vendor", thisVendor);
      Order thisOrder = new Order(title, date, vendorId, price);
      List<Order> theseOrders = thisVendor.Orders;
      vendorWithOrders.Add("orders", theseOrders);
      return View("Show", vendorWithOrders);
    }
  }
}