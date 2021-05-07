using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project.Stores
{
    public class HUEPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HUECheesePizza();
                case "greek":
                    return new HUEGreekPizza();
                case "pepperoni":
                    return new HUEPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
