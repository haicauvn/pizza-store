using System;

namespace pizza_store_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzstore = new PizzaStore();
            pizzstore.OrderPizza("chesse");
            pizzstore.OrderPizza("greek");
            pizzstore.OrderPizza("pepperoni");
            pizzstore.OrderPizza("sugas");
        }
    }
}
