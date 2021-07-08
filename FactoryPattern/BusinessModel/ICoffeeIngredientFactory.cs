using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.Models;

namespace CoffeeFactory.BusinessModel {
  interface ICoffeeIngredientFactory {
    Roast createRoast();
    Milk createMilk();
    Mocha createMocha();
    Soy createSoy();
    Whip createWhip();
  }
}
