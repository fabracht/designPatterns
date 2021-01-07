using factoryPattern.Products;
using factoryPattern.types;

namespace factoryPattern.factory
{
    public class KnifeFactory
    {
        public Knife createKnife(EKnifeType knifeType)
        {
            Knife knife = new(knifeType);

            return knife;
        }
        public Knife createKnife(string knifeType)
        {
            Knife knife = new(knifeType);

            return knife;
        }
    }
}