using factoryPattern.Products;

namespace factoryPattern.abstracts
{
    public abstract class KnifeStore
    {

        public Knife orderKnife(string knifeType)
        {
            Knife knife;

            // Create a knife
            knife = createKnife(knifeType);
            knife.sharpen();
            knife.polish();
            knife.package();

            return knife;
        }

        protected abstract Knife createKnife(string knifeType);
    }
}