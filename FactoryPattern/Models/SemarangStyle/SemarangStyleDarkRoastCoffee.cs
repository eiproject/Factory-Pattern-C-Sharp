using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class SemarangStyleDarkRoastCoffee : Coffee {
    internal SemarangStyleDarkRoastCoffee(ICoffeeIngredientFactory factory) : base(factory) {
      _coffeeName = "Semarang Style Dark Roast Coffee";
    }
  }
}
