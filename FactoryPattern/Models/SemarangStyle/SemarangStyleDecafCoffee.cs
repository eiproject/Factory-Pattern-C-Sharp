using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class SemarangStyleDecafCoffee  : Coffee {
    internal SemarangStyleDecafCoffee(ICoffeeIngredientFactory factory) : base(factory) {
      _coffeeName = "Semarang Style Decaf Coffee";
    }

  }
}
