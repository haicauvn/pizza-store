using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class DNCheesePizza : Pizza
    {
        public DNCheesePizza()
        {
            name = "DN The best cheese pizza";
            dough = "DN Very thin dough";
            sauce = "DN Very spicy sauce";
            toppings.Add("Black Olives");
            toppings.Add("Cheese");
        }

    }
}
