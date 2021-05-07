using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class HCMCheesePizza : Pizza
    {
        public HCMCheesePizza()
        {
            name = "HCM The best cheese pizza";
            dough = "HCM Very thin dough";
            sauce = "HCM Very spicy sauce";
            toppings.Add("Black Olives");
            toppings.Add("Cheese");
        }

    }
}
