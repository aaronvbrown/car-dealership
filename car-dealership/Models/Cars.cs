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

    private static ArrayList<Car> _cars = new ArrayList<Car>();

    public Car(string description, string model, string make, int year)
    {
      Description = description;
      Model = model;
      Make = make;
      Year = year;
      _cars.Add(this);
      Id = _instances.Count;
    }

    
  }
}