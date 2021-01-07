using factoryPattern.abstracts;
using factoryPattern.Products;

namespace factoryPattern.stores
{
    public class BudgetKnifeStore : KnifeStore
    {
        protected override Knife createKnife(string knifeType)
        {
            Knife knife = new(knifeType);
            System.Console.WriteLine($"One new budget {knifeType} knife");
            return knife;
        }
    }
}