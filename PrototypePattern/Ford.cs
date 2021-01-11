namespace PrototypePattern
{
    public class Ford : BasicCar
    {
        public Ford(string model)
        {
            ModelName = model;
            basePrice = 1400.0d;
        }

        public override BasicCar Clone()
        {
            return this.MemberwiseClone() as Ford;
        }
    }
}