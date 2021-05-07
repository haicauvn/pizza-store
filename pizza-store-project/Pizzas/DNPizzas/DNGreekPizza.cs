using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class DNGreekPizza : Pizza
    {
        public DNGreekPizza()
        {
            name = "DN A good Greek pizza";
            dough = "DN Thin dough";
            sauce = "DN Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Pomato");
        }

    }
}
