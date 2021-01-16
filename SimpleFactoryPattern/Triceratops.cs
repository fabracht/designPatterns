namespace SimpleFactoryPattern
{
    public class Triceratops : IDinossaur
    {
        private int _numberOfLegs;
        private int _numberOfTeeth;
        private bool _isPredator;

        public int NumberOfLegs
        { get => _numberOfLegs; set => _numberOfLegs = value; }
        public int NumberOfTeeth { get => _numberOfTeeth; set => _numberOfTeeth = value; }
        public bool IsPredator { get => _isPredator; set => _isPredator = value; }

        public void Fly()
        {
            System.Console.WriteLine("This animal does not fly"); ;
        }

        public void Roar()
        {
            System.Console.WriteLine("Baritone Growl!");
        }

        public void Run()
        {
            System.Console.WriteLine("Padaboom, padaboom, padaboom!"); ;
        }
    }
}