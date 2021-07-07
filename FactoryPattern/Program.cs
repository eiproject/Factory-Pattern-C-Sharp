using System;
using CoffeeFactory.BusinessModel;
using CoffeeFactory.Models;

namespace CoffeeFactory {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Coffee - Factory Pattern!");
      ICoffeeStore bdStore = new BandungStore();
      ICoffeeStore smStore = new SemarangStore();

      ICoffee coffee = bdStore.OrderCoffee("Dark Roast");
      Console.WriteLine(coffee.GetName());
    }
  }
}
