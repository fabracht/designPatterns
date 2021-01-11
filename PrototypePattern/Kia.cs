namespace PrototypePattern
{
    public class Kia : BasicCar
    {
        public Kia(string model)
        {
            ModelName = model;
            basePrice = 1000.0d;
        }

        public override BasicCar Clone()
        {
            return this.MemberwiseClone() as Kia;
        }

    }
}