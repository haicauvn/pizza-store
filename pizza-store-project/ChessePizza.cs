using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    class ChessePizza : Pizza
    {
        public ChessePizza()
        {
            name = "The best cheese pizza";
            dough = "Very thin dough";
            sauce = "Very spicy sauce";
            toppings.Add("Black Olives");
            toppings.Add("Cheese");
        }

        public override void Box()
        {
            Console.WriteLine("Box[" + name + "]");
        }
    }
}
