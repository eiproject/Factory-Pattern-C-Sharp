using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeFactory.BusinessModel {
  interface ICoffee {
    void Prepare();
    void MixWithBoiledWater();
    void Stir();
    void Plating();
    string GetName();
  }
}
