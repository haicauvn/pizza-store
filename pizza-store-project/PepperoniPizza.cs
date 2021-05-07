using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "The best Pepperoni pizza";
            dough = "Thick dough";
            sauce = "Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
