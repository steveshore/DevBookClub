using System;
namespace InterfacesAndAbstractClasses
{
    interface IOrder
    {
        MealDeal GetOrder();
        void PrintOrder(MealDeal meal);
    }
}
