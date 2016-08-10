using System;
using InterfacesAndAbstractClasses.Models;

namespace InterfacesAndAbstractClasses
{

    public class Lunch
    {
        private static IOrderService OrderServiceFactory(){
            return new OrderService();
        }

        public static void Main(string[] args)
        {
             IOrderService _order = OrderServiceFactory();

            var meal = _order.GetMealDeal();
            if (meal.Entree == "sandwich")
            {
                meal = _order.GetSandwich(meal);
                _order.PrintSandwichOrder((SandwichDeal)meal);

            }
            else if (meal.Entree == "burrito")
            {
                meal = _order.GetBurrito(meal);
                _order.PrintBurritoOrder((BurritoDeal)meal);
            }
            else
            {
                Console.Write("Your spelling's not great. Try again:\n");
                meal = _order.GetMealDeal();
            }
        }
    }
}
