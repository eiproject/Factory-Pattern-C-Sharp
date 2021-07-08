using System;
using CoffeeFactory.BusinessModel;
using CoffeeFactory.Models;

namespace CoffeeFactory {
  class Run {
    private ICoffeeIngredientFactory _factory;

    internal Run() {
     _factory = new CoffeeIngredientFactory();  
    }

    internal void Bandung() {
      ICoffeeStore bdStore = new BandungStore(_factory);
      ICoffee coffee = bdStore.OrderCoffee("Dark Roast");
      Console.WriteLine("Here your order is ready: " + coffee.GetName());
    }
    internal void Semarang() {
      ICoffeeStore smStore = new SemarangStore(_factory);
      ICoffee smCoffee = smStore.OrderCoffee("House Blend");
      Console.WriteLine("Here your order is ready: " + smCoffee.GetName());
    }
  }
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Coffee - Factory Pattern!");
      Run store = new Run();
      store.Bandung();
      store.Semarang();
    }
  }
}
