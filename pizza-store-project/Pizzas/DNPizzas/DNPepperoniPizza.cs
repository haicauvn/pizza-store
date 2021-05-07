using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class DNPepperoniPizza : Pizza
    {
        public DNPepperoniPizza()
        {
            name = "DN The best Pepperoni pizza";
            dough = "DN Thick dough";
            sauce = "DN Sweet sauce";
            toppings.Add("Tomato");
        }

    }
}
