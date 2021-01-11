using System;
/* The core idea of this pattern is to create an object that is based on another object. This existing object acts as a template for the new object. */
namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("******Prototype Pattern******");
            BasicCar greenKia = new Kia("Green Kia");
            BasicCar yellowFord = new Ford("Yellow Ford");

            BasicCar greenBasicCar = greenKia.Clone();

            greenBasicCar.onRoadPrice = greenBasicCar.basePrice + greenBasicCar.SetAditionalPrice();
            System.Console.WriteLine($"The greenBasicCar is: {greenBasicCar.ModelName}, and it's price is {String.Format("{0:0.00}", greenBasicCar.onRoadPrice)}");

            greenBasicCar = yellowFord.Clone();
            greenBasicCar.onRoadPrice = greenBasicCar.basePrice + greenBasicCar.SetAditionalPrice();
            System.Console.WriteLine($"The greenBasicCar is: {greenBasicCar.ModelName}, and it's price is {String.Format("{0:0.00}", greenBasicCar.onRoadPrice)}");
        }
    }
}
