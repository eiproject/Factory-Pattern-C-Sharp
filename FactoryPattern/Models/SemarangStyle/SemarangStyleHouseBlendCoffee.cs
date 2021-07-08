using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class SemarangStyleHouseBlendCoffee : Coffee {
    internal SemarangStyleHouseBlendCoffee(ICoffeeIngredientFactory factory) : base(factory) {
      _coffeeName = "Semarang Style House Blend Coffee";
    }

  }
}
