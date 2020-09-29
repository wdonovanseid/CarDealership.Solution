using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CarController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      Car.ClearAllDefault();
      return View(Car.CarsMatchingSearch);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      Car.ClearAllSearch();
      Car.MakeDefaultCars();
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string maxPrice)
    {
      Car.GetAllWorth(maxPrice);
      return RedirectToAction("Index");
    }

  }
}