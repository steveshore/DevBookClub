using System;
using InterfacesAndAbstractClasses.Models;

namespace InterfacesAndAbstractClasses
{
    public interface IOrderService
    {
        BurritoDeal GetBurrito(MealDeal meal);

        MealDeal GetMealDeal();
        
        SandwichDeal GetSandwich(MealDeal meal);
        
        void PrintBurritoOrder(BurritoDeal burritoMeal);
        
        void PrintSandwichOrder(SandwichDeal meal);
    }
}
