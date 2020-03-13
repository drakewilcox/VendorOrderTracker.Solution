using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };
    private static int _count = 1;

    public Order(string title, string description, decimal price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _count++;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int id)
    {
      foreach (Order order in _instances)
      {
        if (order.Id == id)
        {
          return order;
        }
      }
      return _instances[0];
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int id)
    {
      foreach (Order order in _instances)
      {
        if (order.Id == id)
        {
          return order;
        }
      }
      return _instances[0];
    }
  }
}