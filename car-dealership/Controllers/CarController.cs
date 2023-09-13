using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Controllers
{
  public class CarController : Controller
  {
    [HttpGet("/cars/")]
    public ActionResult Index()
    {
      return View();
      //todo: list all cars 
    }
  }

}
