namespace PrototypeWithFactory
{
    public class KiaCar : BasicCar
    {
        public KiaCar(string name) : base(name)
        {
            BasePrice = 4500.0d;
        }

        public override BasicCar Clone()
        {
            return this.MemberwiseClone() as KiaCar;
        }
    }
}