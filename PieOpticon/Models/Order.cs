using System.Collections.Generic;

namespace PieOpticon.Models
{
  public class Order
  {
    private static List<Order> _allOrders = new List<Order> {};
    public int Id { get; }
    public int VendorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public List<Vendor> Vendors { get; set; }

    public Order (string orderTitle, string date, int vendorId, int price)
    {
      Title = orderTitle;
      Date = date;
      VendorId = vendorId;
      Price = price;
      Description = $"{Date} | {Vendor.Find(vendorId).Name} | ${Price}";
      _allOrders.Add(this);
      Id = _allOrders.Count;
      Vendors = new List<Vendor>{};
    }

    public static List<Order> GetAll()
    {
      return _allOrders;
    }

    // public static Order Find(int searchId)
    // {
    //   return _allOrders[searchId - 1];
    // }

    public static void ClearAll()
    {
      _allOrders.Clear();
    }
  }
}