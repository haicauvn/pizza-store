using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project.Stores
{
    public class HCMPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HCMCheesePizza();
                case "greek":
                    return new HCMGreekPizza();
                case "pepperoni":
                    return new HCMPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
