using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  abstract class CoffeeStore : ICoffeeStore {
    private ICoffee _coffee;
    public abstract ICoffee CreateCoffee(string C);

    ICoffee ICoffeeStore.OrderCoffee(string type) {
      _coffee = CreateCoffee(type);

      _coffee.Prepare();
      _coffee.MixWithBoiledWater();
      _coffee.Stir();
      _coffee.Plating();

      return _coffee;
    }
  }
}
