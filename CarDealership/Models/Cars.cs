using System.Collections.Generic;
using System;

namespace CarDealership.Models {

  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    private static List<Car> _instances = new List<Car> {};
    public static List<Car> CarsMatchingSearch = new List<Car> {};

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _instances.Add(this);
    }

    public static void MakeDefaultCars()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);
    }

    public static void ClearAllDefault()
    {
      _instances.Clear();
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAllSearch()
    {
      CarsMatchingSearch.Clear();
    }

    public static List<Car> GetAllWorth(string maxPrice)
    {
      int maxPriceInt = int.Parse(maxPrice);
      foreach (Car automobile in _instances)
      {
        if (automobile.WorthBuying(maxPriceInt))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }
      return CarsMatchingSearch;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
  }

}