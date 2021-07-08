using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class SemarangStore : CoffeeStore{
    private Coffee _coffee;
    private ICoffeeIngredientFactory _factory;
    internal SemarangStore(ICoffeeIngredientFactory factory) {
      _factory = factory;
    }
    public override ICoffee CreateCoffee(string type) {

      if (type.Equals("Dark Roast")) {
        _coffee = new SemarangStyleDarkRoastCoffee(_factory);
      }
      else if (type.Equals("Decaf")) {
        _coffee = new SemarangStyleDecafCoffee(_factory);
      }
      else if (type.Equals("Espresso")) {
        _coffee = new SemarangStyleEspressoCoffee(_factory);
      }
      else if (type.Equals("House Blend")) {
        _coffee = new SemarangStyleHouseBlendCoffee(_factory);
      }
      else {
        _coffee = null;
      }
      return _coffee;
    }
  }
}
