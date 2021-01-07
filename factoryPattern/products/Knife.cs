using System;
using factoryPattern.types;

namespace factoryPattern.Products
{
    public class Knife : IKnife
    {
        public Knife(EKnifeType knifeType)
        {
            this.knifeType = knifeType;
        }

        public Knife(string knifeType1)
        {
            Enum.TryParse<EKnifeType>(knifeType1, true, out EKnifeType result);
            this.knifeType = result;
        }

        public EKnifeType knifeType { get; set; }
        public string KnifeType { get; }

        public void package()
        {
            System.Console.WriteLine($"Packaging a {knifeType} knife!");

        }

        public void polish()
        {
            System.Console.WriteLine($"Polishing a {knifeType} knife!");
        }

        public void sharpen()
        {
            System.Console.WriteLine($"Sharpening a {knifeType} knife!");
        }
    }
}