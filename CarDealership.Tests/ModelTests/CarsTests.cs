using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealership.Models;
using System.Collections.Generic;
using System.Collections;
using System;


namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests
  {
    [TestMethod]
    public void CarConstructor_CreateInstanceOfCar_Car()
    {
      Car newCar = new Car("new", "honda", "civic", 2023);
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
  }
}