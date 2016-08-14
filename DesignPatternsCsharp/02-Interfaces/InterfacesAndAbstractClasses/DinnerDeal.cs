using System;

namespace InterfacesAndAbstractClasses
{
    public class DinnerDeal
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

        //This method finishes the dinner order by 
        //filling in the final entree specific details
        public DinnerDeal GetOrder()
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

        //This method prints out a completed order
        public void PrintOrder(DinnerDeal meal)
        {
            var cheese = meal.Cheese ? "with shredded parmesan" : "without shredded parmesan";

            Console.Write("You ordered a " + meal.Meat + " " + meal.Entree + " " + cheese + " with a " + meal.Bread + " bread roll " + " and\n" + meal.Side + " on the side with " + meal.Drink + " to drink (press enter to exit)");
            Console.ReadKey();
        }





        //This method gets the basic Meal so the appropriate 
        //entree specific questions can then be asked
        private DinnerDeal GetMealDeal()
        {
            return new DinnerDeal
            {
                Entree = GetEntree(),
                Drink = GetDrink(),
                Side = GetSide()
            };
        }

        //This method this method gets the dinner spefic entree choice 
        //if they do not spell it right it asks again
        public string GetEntree()
        {
            Console.Write("Would you like a Steak or Chicken?:\n");
            var entree = Console.ReadLine();

            if (entree != null)
            {
                entree = entree.ToLower().Trim();

                if (entree == "steak" || entree == "chicken")
                {
                    return entree;
                }
            }

            Console.Write("Your spelling's not great. Try again...\n\n");
            return GetEntree();
        }
    }
}
