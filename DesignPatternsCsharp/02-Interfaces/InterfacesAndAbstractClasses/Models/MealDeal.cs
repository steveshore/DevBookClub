using System;
namespace InterfacesAndAbstractClasses.Models
{
    public abstract class MealDeal
    {
        public string Entree { get; set; }
        public string Drink { get; set; }
        public string Side { get; set; }

        private string GetEntree()
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
