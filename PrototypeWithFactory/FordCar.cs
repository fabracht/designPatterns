namespace PrototypeWithFactory
{
    public class FordCar : BasicCar
    {
        public FordCar(string name) : base(name)
        {
            BasePrice = 1300.0d;
        }

        public override BasicCar Clone()
        {
            return this.MemberwiseClone() as FordCar;
        }
    }
}