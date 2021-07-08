using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class BandungStyleHouseBlendCoffee : Coffee {
    internal BandungStyleHouseBlendCoffee(ICoffeeIngredientFactory factory) : base(factory) {
      _coffeeName = "Bandung Style House Blend Coffee";
    }
  }
}
