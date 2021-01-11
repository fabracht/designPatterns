using System;

namespace PrototypeWithFactory
{
    public abstract class BasicCar
    {
        private double _basePrice = 0.0d;
        private double _onRoadPrice = 0.0d;


        protected BasicCar(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new System.ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
            }

            ModelName = name;
        }
        public string ModelName { get; set; }
        public double BasePrice { get => _basePrice; set => _basePrice = value; }
        public double OnRoadPrice { get => _onRoadPrice; set => _onRoadPrice = value; }

        public abstract BasicCar Clone();

        public double SetAddicionalPrice()
        {
            Random random = new Random();

            double additionalPrice = random.NextDouble() * _basePrice;
            return additionalPrice;

        }
    }
}