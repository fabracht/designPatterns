using System;
using factoryPattern.Products;
using factoryPattern.stores;
using factoryPattern.types;

namespace factoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BudgetKnifeStore bStore = new();
            var budgetChefsKnife = bStore.orderKnife("chefs");
        }
    }
}
