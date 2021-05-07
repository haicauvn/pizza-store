using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    public abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        public abstract Pizza CreatePizza(string type);
    }
}
