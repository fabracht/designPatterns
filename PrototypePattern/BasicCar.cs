using System;

namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public double basePrice = 0.0d;
        public double onRoadPrice = 0.0d;

        public string ModelName { get; set; }

        public BasicCar()
        {
        }

        public double SetAditionalPrice()
        {
            Random random = new Random();

            double additionalPrice = random.NextDouble() * basePrice;
            return additionalPrice;
        }

        public abstract BasicCar Clone();

    }
}