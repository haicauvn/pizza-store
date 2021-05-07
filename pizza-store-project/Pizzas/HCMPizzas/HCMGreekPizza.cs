using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class HCMGreekPizza : Pizza
    {
        public HCMGreekPizza()
        {
            name = "HCM A good Greek pizza";
            dough = "HCM Thin dough";
            sauce = "HCM Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Pomato");
        }

    }
}
