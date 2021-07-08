using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class BandungStyleEspressoCoffee : Coffee{
    internal BandungStyleEspressoCoffee(ICoffeeIngredientFactory factory) : base(factory) {
      _coffeeName = "Bandung Style Espresso Coffee";
    }
  }
}
