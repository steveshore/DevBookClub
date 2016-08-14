using System;

namespace InterfacesAndAbstractClasses
{
    public class LunchDeal 
    {
        //Shared Infromation between meals
        //These fields all seem very similar to Dinner deal. 
        //Does this seem redundant?
        public string Meal { get; set; }
        public string Entree { get; set; }
        public string Meat { get; set; }
        public string Bread { get; set; }
        public bool Cheese { get; set; }
        public string Drink { get; set; }
        public string Side { get; set; }

        private string GetDrink()
        {
            Console.Write("What would you like to drink?:\n");
            var drink = Console.ReadLine();

            if (drink != null)
                return drink.ToLower().Trim();

            Console.Write("Please enter a valid drink?:\n");
            return GetDrink();
        }

        private string GetSide()
        {
            Console.Write("What side would you like?:\n");
            var side = Console.ReadLine();

            if (side != null)
                return side.ToLower().Trim();

            Console.Write("Please enter a valid side?:\n");
            return GetSide();
        }



        //These all look different, but share very 
        //similar signatures and similar functionality

        //This method finishes the lunch order by 
        //filling in the final entree specific details 
        public LunchDeal GetOrder()
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

        //This method prints out a completed order
        public void PrintOrder(LunchDeal meal)
        {
            var cheese = meal.Cheese ? "with cheese" : "without cheese";
            var carb = meal.Entree == "burrito" ? "tortilla" : "bread";
            Console.Write("You ordered a " + meal.Meat + " " + meal.Entree + " " + cheese + " with " + meal.Bread + " " + carb + " and\n" + meal.Side + " on the side with " + meal.Drink + " to drink (press enter to exit)");
            Console.ReadKey();
        }




        //This method gets the basic Meal so the appropriate 
        //entree specific questions can then be asked
        private LunchDeal GetMealDeal()
        {
            return new LunchDeal
            {
                Entree = GetEntree(),
                Drink = GetDrink(),
                Side = GetSide()
            };
        }

        //This method this method gets the lunch spefic entree choice 
        //if they do not spell it right it asks again
        private string GetEntree()
        {
            Console.Write("Would you like a sandwich or a burrito?:\n");
            var entree = Console.ReadLine();

            if (entree != null)
            {
                entree = entree.ToLower().Trim();

                if (entree == "burrito" || entree == "sandwich")
                {
                    return entree;
                }
            }
                
            Console.Write("Your spelling's not great. Try again...\n\n");
            return GetEntree();
        }
    }
}
