using System;

namespace InterfacesAndAbstractClasses
{
    public abstract class MealDeal
    {
        public string Meal { get; set; }
        public string Entree { get; set; }
        public string Meat { get; set; }
        public string Bread { get; set; }
        public bool Cheese { get; set; }
        public string Drink { get; set; }
        public string Side { get; set; }

        public abstract string GetEntree();

        protected string GetDrink()
        {
            Console.Write("What would you like to drink?:\n");
            return Console.ReadLine().ToLower().Trim();
        }

        protected string GetSide()
        {
            Console.Write("What side would you like?:\n");
            return Console.ReadLine().ToLower().Trim();
        }
    }
}
