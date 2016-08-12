using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    public class DinnerDeal : MealDeal, IOrder
    {

        public MealDeal GetOrder()
        {
            var meal = GetMealDeal();

            if (meal.Entree == "steak")
            {
                Console.Write("Would you like ribeye or sirloin steak?:\n");
                meal.Meat = Console.ReadLine().ToLower().Trim();
            }

            if (meal.Entree == "chicken")
            {
                Console.Write("Would you like chicken breast or thigh?:\n");
                meal.Meat = Console.ReadLine().ToLower().Trim();
            }

            Console.Write("Would you like an italian or rye bread roll?:\n");
            meal.Bread = Console.ReadLine().ToLower().Trim();

            Console.Write("Would you like a shredded parmesan cheese? (yes or no):\n");
            meal.Cheese = Console.ReadLine().ToLower().Trim() == "yes" ? true : false;

            return meal;
        }

        public void PrintOrder(MealDeal meal)
        {
            var cheese = meal.Cheese ? "with shredded parmesan" : "without shredded parmesan";

            Console.Write("You ordered a " + meal.Meat + " " + meal.Entree + " " + cheese + " with a " + meal.Bread + " bread roll " + " and\n" + meal.Side + " on the side with " + meal.Drink + " to drink (press enter to exit)");
            Console.ReadKey();
        }

        private MealDeal GetMealDeal()
        {
            return new DinnerDeal
            {
                Entree = GetEntree(),
                Drink = GetDrink(),
                Side = GetSide()
            };
        }

        public override string GetEntree()
        {
            Console.Write("Would you like a Steak or Chicken?:\n");
            var entree = Console.ReadLine().ToLower().Trim();

            if (entree == "steak" || entree == "chicken")
            {
                return entree;
            }

            Console.Write("Your spelling's not great. Try again...\n\n");
            return GetEntree();
        }
    }
}
