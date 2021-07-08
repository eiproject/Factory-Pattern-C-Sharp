using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.BusinessModel;

namespace CoffeeFactory.Models {
  class SemarangStore : CoffeeStore{
    private Coffee _coffee;
    public override ICoffee CreateCoffee(string type) {

      if (type.Equals("Dark Roast")) {
        _coffee = new SemarangStyleDarkRoastCoffee();
      }
      else if (type.Equals("Decaf")) {
        _coffee = new SemarangStyleDecafCoffee();
      }
      else if (type.Equals("Espresso")) {
        _coffee = new SemarangStyleEspressoCoffee();
      }
      else if (type.Equals("House Blend")) {
        _coffee = new SemarangStyleHouseBlendCoffee();
      }
      else {
        _coffee = null;
      }
      return _coffee;
    }
  }
}
