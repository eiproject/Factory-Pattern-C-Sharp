using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  abstract class Coffee : ICoffee {
    protected string _coffeeName;
    private Milk _milk;
    private Mocha _mocha;
    private Roast _roast;
    private Soy _soy;
    private Whip _whip;
    private ICoffeeIngredientFactory _ingredientFactory;

    internal Coffee(ICoffeeIngredientFactory factory) {
      _ingredientFactory = factory;
    }

    // Milk, Mocha, Soy, Whip
    void ICoffee.Prepare() {
      Console.WriteLine("Preparing...");
      _milk = _ingredientFactory.createMilk();
      _mocha = _ingredientFactory.createMocha();
      _roast= _ingredientFactory.createRoast();
      _soy = _ingredientFactory.createSoy();
      _whip = _ingredientFactory.createWhip();
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
      Console.WriteLine(this._coffeeName + ". Done");
    }

    string ICoffee.GetName() {
      return _coffeeName;
    }
  }
}
