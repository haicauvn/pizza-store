using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class HUECheesePizza : Pizza
    {
        public HUECheesePizza()
        {
            name = "HUE The best cheese pizza";
            dough = "HUE Very thin dough";
            sauce = "HUE Very spicy sauce";
            toppings.Add("Black Olives");
            toppings.Add("Cheese");
        }

    }
}
