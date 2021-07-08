using System;
using CoffeeFactory.BusinessModel;
using CoffeeFactory.Models;

namespace CoffeeFactory {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Coffee - Factory Pattern!");
      ICoffeeStore bdStore = new BandungStore();

      ICoffee coffee = bdStore.OrderCoffee("Dark Roast");
      Console.WriteLine("Here your order is ready: " + coffee.GetName());

      ICoffeeStore smStore = new SemarangStore();
      ICoffee smCoffee = smStore.OrderCoffee("House Blend");
      Console.WriteLine("Here your order is ready: " + smCoffee.GetName());
    }
  }
}
