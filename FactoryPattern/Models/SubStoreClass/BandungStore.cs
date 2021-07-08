using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class BandungStore : CoffeeStore {
    private Coffee _coffee;
    public override ICoffee CreateCoffee(string type) {

      if (type.Equals("Dark Roast")) {
        _coffee = new BandungStyleDarkRoastCoffee();
      }
      else if (type.Equals("Decaf")) {
        _coffee = new BandungStyleDecafCoffee();
      }
      else if (type.Equals("Espresso")) {
        _coffee = new BandungStyleEspressoCoffee();
      }
      else if (type.Equals("House Blend")) {
        _coffee = new BandungStyleHouseBlendCoffee();
      }
      else {
        _coffee = null;
      }
      return _coffee;
    }
  }
}
