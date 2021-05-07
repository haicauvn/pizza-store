using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_store_project
{
    abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<String> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Prepare " + name);
            Console.WriteLine("Tossing dough... " + dough);
            Console.WriteLine("Adding sauce... " + sauce);
            Console.WriteLine("Adding toppings:");
            toppings?.ForEach((topping) =>
               Console.WriteLine("\t" + topping)
            );
        }

        public void Bake()
        {
            Console.WriteLine("Baking " + name + " in 30 min");
        }

        public void Cut()
        {
            Console.WriteLine("Cuting " + name);
        }

        public void Box()
        {
            Console.WriteLine("Boxing " + name);
        }
    }
}
