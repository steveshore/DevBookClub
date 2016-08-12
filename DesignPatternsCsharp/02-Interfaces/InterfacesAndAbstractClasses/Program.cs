using System;

namespace InterfacesAndAbstractClasses
{

    public class Lunch
    {

        public static void Main(string[] args)
        {
            var meal = GetMeal();
            IOrder order;

            if (meal == "lunch")
            {
                order = new LunchDeal();
                var mealOrder = order.GetOrder();
                order.PrintOrder(mealOrder);
            }

            if (meal == "dinner")
            {
                order = new DinnerDeal();
                var mealOrder = order.GetOrder();
                order.PrintOrder(mealOrder);
            }

        }

        public static string GetMeal()
        {
            Console.Write("Would you like Lunch or Dinner?:\n");
            var meal = Console.ReadLine().ToLower().Trim();

            if (meal == "lunch" || meal == "dinner")
            {
                return meal;
            }

            Console.Write("That's not a meal. Try again...\n\n");
            return GetMeal();
        }
    }
}
