using Microsoft.AspNetCore.Mvc;
using PieOpticon.Models;
using System.Collections.Generic;

namespace PieOpticon.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id)
    {
      Vendor vendor = Vendor.Find(id);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order thisOrder = Order.Find(orderId);
      Vendor thisVendor = Vendor.Find(vendorId);
      Dictionary<string, object> vendorWithOrders = new Dictionary<string, object>();
      vendorWithOrders.Add("order", thisOrder);
      vendorWithOrders.Add("vendor", thisVendor);
      return View(vendorWithOrders);
    }

    [HttpPost("/vendors/{vendorId}/orders/delete")]
    public ActionResult Delete(int vendorId, int orderId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      vendor.Orders.RemoveAt(orderId-1);
      return View();
    }
  }
}
