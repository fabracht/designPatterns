using System;

namespace BuilderPattern
{
    /* Builder patterns are useful because they allow you to control the assembly order of the object you are trying to create. This allows one to define a product based on what you put into it, much like putting together a computer from parts. It also allows you to convert from one product to another, e.g., you can use this pattern to convert from RTF to ASCII.
    To start, checkout the interface IBuilder */

    /* If you came back from a tour of the implementation, you're ready to start the program */
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Builder Patter:");
            // First, we create the director, he's in control of the operation
            Director director = new();

            // Now we instanciate the products, remember that the products are implementations of the interface IBuilder
            IBuilder b1 = new Car("Ford");
            IBuilder b2 = new Motorcycle("Honda");

            // Let's make the car
            director.Construct(b1);
            ProductSpecification p1 = b1.GetVehicle();
            p1.Show();

            // Let's make the bike
            director.Construct(b2);
            ProductSpecification p2 = b2.GetVehicle();
            p2.Show();
        }
    }
}
