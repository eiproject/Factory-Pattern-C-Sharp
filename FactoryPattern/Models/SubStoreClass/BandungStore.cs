using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class BandungStore : CoffeeStore {
    private ICoffeeIngredientFactory _factory;
    private Coffee _coffee;
    internal BandungStore(ICoffeeIngredientFactory factory) {
      _factory = factory;
    }
    public override ICoffee CreateCoffee(string type) {

      if (type.Equals("Dark Roast")) {
        _coffee = new BandungStyleDarkRoastCoffee(_factory);
      }
      else if (type.Equals("Decaf")) {
        _coffee = new BandungStyleDecafCoffee(_factory);
      }
      else if (type.Equals("Espresso")) {
        _coffee = new BandungStyleEspressoCoffee(_factory);
      }
      else if (type.Equals("House Blend")) {
        _coffee = new BandungStyleHouseBlendCoffee(_factory);
      }
      else {
        _coffee = null;
      }
      return _coffee;
    }
  }
}
