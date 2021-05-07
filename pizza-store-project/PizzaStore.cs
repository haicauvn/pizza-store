using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class PizzaStore
    {
        public void OrderPizza()
        {
            var pizza = new Pizza();
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
