namespace SimpleFactoryPattern
{
    public interface IDinossaur
    {

        public int NumberOfLegs { get; set; }
        public int NumberOfTeeth { get; set; }
        public bool IsPredator { get; set; }

        public void Roar();
        public void Run();
        public void Fly();
    }
}