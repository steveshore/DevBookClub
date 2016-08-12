using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    public class LunchDeal : MealDeal, IOrder
    {

        public MealDeal GetOrder()
        {
            var meal = GetMealDeal();

            if (meal.Entree == "sandwich")
            {
                Console.Write("Would you like sliced ham or turkey on your sandwich?:\n");
                meal.Meat = Console.ReadLine().ToLower().Trim();

                Console.Write("Would you like white or wheat bread?:\n");
                meal.Bread = Console.ReadLine().ToLower().Trim();

                Console.Write("Would you like a slice of cheese? (yes or no):\n");
                meal.Cheese = Console.ReadLine().ToLower().Trim() == "yes" ? true : false;
            }

            if (meal.Entree == "burrito")
            {
                Console.Write("Would you like shredded beef or chicken on your burrito?:\n");
                meal.Meat = Console.ReadLine().ToLower().Trim();

                Console.Write("Would you like a flour or wheat tortilla?:\n");
                meal.Bread = Console.ReadLine().ToLower().Trim();

                Console.Write("Would you like a shredded cheese? (yes or no):\n");
                meal.Cheese = Console.ReadLine().ToLower().Trim() == "yes" ? true : false;
            }

            return meal;
        }

        public void PrintOrder(MealDeal meal)
        {
            var cheese = meal.Cheese ? "with cheese" : "without cheese";
            var carb = meal.Entree == "burrito" ? "tortilla" : "bread";
            Console.Write("You ordered a " + meal.Meat + " " + meal.Entree + " " + cheese + " with " + meal.Bread + " " + carb + " and\n" + meal.Side + " on the side with " + meal.Drink + " to drink (press enter to exit)");
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
            Console.Write("Would you like a sandwich or a burrito?:\n");
            var entree = Console.ReadLine().ToLower().Trim();

            if (entree == "burrito" || entree == "sandwich")
            {
                return entree;
            }

            Console.Write("Your spelling's not great. Try again...\n\n");
            return GetEntree();
        }
    }
}
