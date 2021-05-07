using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class HCMPepperoniPizza : Pizza
    {
        public HCMPepperoniPizza()
        {
            name = "HCM The best Pepperoni pizza";
            dough = "HCM Thick dough";
            sauce = "HCM Sweet sauce";
            toppings.Add("Tomato");
        }

    }
}
