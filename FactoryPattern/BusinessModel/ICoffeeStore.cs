using System;
using System.Collections.Generic;
using System.Text;
using CoffeeFactory.Models;

namespace CoffeeFactory.BusinessModel {
  interface ICoffeeStore {
    abstract ICoffee CreateCoffee(String C);
    ICoffee OrderCoffee(String C);
  }
}
