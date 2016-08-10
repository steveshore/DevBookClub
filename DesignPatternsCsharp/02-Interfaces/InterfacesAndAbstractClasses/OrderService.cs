using System;
using InterfacesAndAbstractClasses.Models;


namespace InterfacesAndAbstractClasses
{
    public class OrderService : InterfacesAndAbstractClasses.IOrderService
    {
        public MealDeal GetMealDeal()
        {
            var meal = new MealDeal
            {
                Entree = GetEntree(),
                Drink = GetDrink(),
                Side = GetSide()
            };
            return meal;
        }

        public BurritoDeal GetBurrito(MealDeal meal)
        {

            Console.Write("Would you like shredded beef or chicken on your burrito?:\n");
            var meat = Console.ReadLine().ToLower().Trim();

            Console.Write("Would you like a flour or wheat tortilla?:\n");
            var torilla = Console.ReadLine().ToLower().Trim();

            Console.Write("Would you like a shredded cheese? (yes or no):\n");
            var cheese = Console.ReadLine().ToLower().Trim() == "yes" ? true : false;

            return new BurritoDeal
            {
                Entree = meal.Entree,
                Drink = meal.Drink,
                Side = meal.Side,
                ShreddedMeatType = meat,
                TortillaType = torilla,
                Cheese = cheese
            };
        }

        public SandwichDeal GetSandwich(MealDeal meal)
        {
            Console.Write("Would you like sliced ham or turkey on your sandwich?:\n");
            var meat = Console.ReadLine().ToLower().Trim();

            Console.Write("Would you like white or wheat bread?:\n");
            var bread = Console.ReadLine().ToLower().Trim();

            Console.Write("Would you like a slice of cheese? (yes or no):\n");
            var cheese = Console.ReadLine().ToLower().Trim() == "yes" ? true : false;

            return new SandwichDeal
            {
                Entree = meal.Entree,
                Drink = meal.Drink,
                Side = meal.Side,
                ColdCutType = meat,
                BreadType = bread,
                Cheese = cheese
            };
        }

        public void PrintSandwichOrder(SandwichDeal meal)
        {
            var cheese = meal.Cheese ? "with cheese" : "without cheese";
            Console.Write("You ordered a " + meal.ColdCutType + " sandwich " + cheese + " on " + meal.BreadType + " bread and\n" + meal.Side + " on the side with " + meal.Drink + " to drink (press enter to exit)");
            Console.ReadKey();
        }

        public void PrintBurritoOrder(BurritoDeal meal)
        {
            var cheese = meal.Cheese ? "with cheese" : "without cheese";
            Console.Write("You ordered a " + meal.ShreddedMeatType + " burrito " + cheese + " in a " + meal.TortillaType + " tortilla and\n" + meal.Side + " on the side with " + meal.Drink + " to drink (press enter to exit)");
            Console.ReadKey();
        }

        private string GetEntree()
        {
            Console.Write("Would you like a sandwich or a burrito?:\n");
            var entree = Console.ReadLine().ToLower().Trim();

            if(entree == "burrito" || entree == "sandwich") {
                return entree;
            }

            Console.Write("Your spelling's not great. Try again...\n\n");
            return GetEntree();
        }

        private string GetDrink()
        {
            Console.Write("What would you like to drink?:\n");
            return Console.ReadLine().ToLower().Trim();
        }

        private string GetSide()
        {
            Console.Write("What side would you like?:\n");
            return Console.ReadLine().ToLower().Trim();
        }
    }
}
