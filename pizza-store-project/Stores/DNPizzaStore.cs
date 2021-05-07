using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project.Stores
{
    public class DNPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new DNCheesePizza();
                case "greek":
                    return new DNGreekPizza();
                case "pepperoni":
                    return new DNPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
