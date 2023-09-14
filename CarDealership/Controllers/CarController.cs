using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarController : Controller
  {
    [HttpGet("/cars/")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
      //todo: list all cars 
    }
    [HttpGet("/cars/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string description, string model, string make, int year)
    {
      Car newCar = new Car(description, model, make, year);
      return RedirectToAction("Index");
    }

    [HttpGet("/cars/{id}")]
    
    public ActionResult Show(int id)
    {
      Car foundCar= Car.Find(id);
      return View(foundCar);
    }
    

  }

}
