using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class BandungStyleDecafCoffee : Coffee{
    internal BandungStyleDecafCoffee(ICoffeeIngredientFactory factory) : base(factory) {
      _coffeeName = "Bandung Style Decaf Coffee";
    }
  }
}
