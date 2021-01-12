using System.Collections.Generic;

namespace BuilderPattern
{
    /* The Product Specification class holds a list (in this particular case a linkedlist, because, why not) with the product specifications. The methods are pretty self explanatory.
    Next, go checkout the actual products, the Motorcyle and the Car */
    public class ProductSpecification
    {
        private LinkedList<string> parts;

        public ProductSpecification()
        {
            parts = new LinkedList<string>();
        }

        public void Add(string part)
        {
            parts.AddLast(part);
        }

        public void Show()
        {
            System.Console.WriteLine("\nProduct Completed:");
            foreach (string part in parts)
            {
                System.Console.WriteLine(part);
            }
        }
    }
}