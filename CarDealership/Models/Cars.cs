using System.Collections.Generic;
using System;

namespace CarDealership.Models
{
  public class Car
  {
    public string Description { get; set; } //type
    public string Model { get; set; }

    public string Make { get; set; }

    public int Year { get; set; }

    public int Id{ get; }

    
    // private static ArrayList _instances = new ArrayList<Car> {};

    private static List<Car> _instances = new List<Car> {};

    public Car(string description, string model, string make, int year)
    {
      Description = description;
      Model = model;
      Make = make;
      Year = year;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
    public static Car Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}