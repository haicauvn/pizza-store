using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class GreekPizza : Pizza
    {
        public GreekPizza()
        {
            name = "A good Greek pizza";
            dough = "Thin dough";
            sauce = "chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Pomato");
        }
    }
}
