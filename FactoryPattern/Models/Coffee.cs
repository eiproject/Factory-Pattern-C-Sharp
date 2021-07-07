using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  abstract class Coffee : ICoffee {
    protected string _coffeeName;

    // Milk, Mocha, Soy, Whip
    void ICoffee.Prepare() {
      Console.WriteLine("Preparing...");
      Console.WriteLine("Prepare coffee, sugar, and mug");
    }
    void ICoffee.MixWithBoiledWater() {
      Console.WriteLine("Pouring water to mug");
    }
    void ICoffee.Stir() {
      Console.WriteLine("Stir coffee and water");
    }
    void ICoffee.Plating() {
      Console.WriteLine("Place the mug on the plate");
      Console.WriteLine(this._coffeeName + "Done");
    }

    string ICoffee.GetName() {
      return _coffeeName;
    }


  }
}
