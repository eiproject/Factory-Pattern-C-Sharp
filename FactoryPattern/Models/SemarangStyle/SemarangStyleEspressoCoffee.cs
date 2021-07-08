using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class SemarangStyleEspressoCoffee : Coffee{
    internal SemarangStyleEspressoCoffee(ICoffeeIngredientFactory factory) : base(factory) {
      _coffeeName = "Semarang Style Espresso Coffee";
    }
  }
}
