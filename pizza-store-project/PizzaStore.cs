using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza;
            switch (type)
            {
                case "chesse":
                    pizza = new ChessePizza();
                    break;
                case "greek":
                    pizza = new GreekPizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                default:
                    Console.WriteLine("We do not have "+ type + " pizza");
                    return;
            }
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

        }
    }
}
