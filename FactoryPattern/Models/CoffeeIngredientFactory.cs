using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class CoffeeIngredientFactory : ICoffeeIngredientFactory {
    internal CoffeeIngredientFactory() {

    }

    Milk ICoffeeIngredientFactory.createMilk() {
      return new Milk();
    }

    Mocha ICoffeeIngredientFactory.createMocha() {
      return new Mocha();
    }

    Roast ICoffeeIngredientFactory.createRoast() {
      return new Roast();
    }

    Soy ICoffeeIngredientFactory.createSoy() {
      return new Soy();
    }

    Whip ICoffeeIngredientFactory.createWhip() {
      return new Whip();
    }
  }
}
