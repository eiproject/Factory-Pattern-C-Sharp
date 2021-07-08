using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class BandungStyleDarkRoastCoffee : Coffee {
    internal BandungStyleDarkRoastCoffee(ICoffeeIngredientFactory factory) : base(factory) {
      _coffeeName = "Bandung Style Dark Roast Coffee";
    }
  }
}
