using System;

namespace PrototypeWithFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Prototype With Factory Pattern*******");
            CarFactory carFactory = new CarFactory();
            // Get a Kia Car
            BasicCar basicCar = carFactory.GetKia();
            basicCar.OnRoadPrice = basicCar.BasePrice + basicCar.SetAddicionalPrice();
            Console.WriteLine($"The BasicCar is: {basicCar.ModelName}, and it's price is {String.Format("{0:0.00}", basicCar.OnRoadPrice)}");

            basicCar = carFactory.GetFord();
            basicCar.OnRoadPrice = basicCar.BasePrice + basicCar.SetAddicionalPrice();
            Console.WriteLine($"The BasicCar is: {basicCar.ModelName}, and it's price is {String.Format("{0:0.00}", basicCar.OnRoadPrice)}");


        }
    }
}
