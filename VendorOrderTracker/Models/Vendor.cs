using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    private static int _count = 1;

    public Vendor(string name, string description, string location)
    {
      Name = name;
      Description = description;
      Location = location;
      _instances.Add(this);
      Id = _count++;
      Orders = new List<Order> { };
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int id)
    {
      foreach (Vendor vendor in _instances)
      {
        if (vendor.Id == id)
        {
          return vendor;
        }
      }
      return _instances[0];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}