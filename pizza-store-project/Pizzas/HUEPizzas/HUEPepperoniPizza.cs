using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class HUEPepperoniPizza : Pizza
    {
        public HUEPepperoniPizza()
        {
            name = "HUE The best Pepperoni pizza";
            dough = "HUE Thick dough";
            sauce = "HUE Sweet sauce";
            toppings.Add("Tomato");
        }

    }
}
