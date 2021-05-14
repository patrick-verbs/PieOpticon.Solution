using System.Collections.Generic;

namespace PieOpticon.Models
{
  public class Vendor
  {
    public int Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _allVendors = new List<Vendor> {};

    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
      _allVendors.Add(this);
      Id = _allVendors.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _allVendors;
    }

    public static Vendor Find(int searchId)
    {
      return _allVendors[searchId - 1];
    }

    public static void ClearAll()
    {
      _allVendors.Clear();
    }
  }
}