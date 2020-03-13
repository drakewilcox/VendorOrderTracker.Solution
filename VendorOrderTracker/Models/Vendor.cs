using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> { };
    private static int _count = 1;

    public Vendor(string name, string description, string location)
    {
      Name = name;
      Description = description;
      Location = location;
      _instances.Add(this);
      Id = _count++;
    }
  }
}