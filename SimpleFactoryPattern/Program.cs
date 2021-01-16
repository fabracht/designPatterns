using System;

namespace SimpleFactoryPattern
{
    /* The Simple Factory is not really a GoF pattern, but it's usefulness awards it a place in this study guide. It's purpose here is to provide the foundation for understanding the Factory Method Pattern, i.e., it makes things easier later on. Feel free to skip this if you're like "Nah, I'm too old for this s***".*/
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactory dinossaurFactory = new();

            Triceratops tripoli = (Triceratops)dinossaurFactory.CreateAnimal(EDinossaur.Triceratops);
            Velociraptor speedy = (Velociraptor)dinossaurFactory.CreateAnimal(EDinossaur.Velociraptor);
            System.Console.WriteLine("As the pack of Velociraptor closes in on its pray, you can hear their communication");
            speedy.Roar();
            System.Console.WriteLine("The Triceratops quickly notices the action and responds in kind");
            tripoli.Roar();
            System.Console.WriteLine("The Velociraptors quickly start running towards the prey");
            speedy.Run();
            System.Console.WriteLine("Too late, the Triceratops noticed the attack, and all the velociraptors can do is hear the distant sounds of the Triceratops' gallop");
            tripoli.Run();
            // Notice that we did not need the Fly method. This is a drawback of the simple factory. It does not avoid the need for implementing unnecessary methods. So the choice of what's listed in the interface needs to be done with care.
            /* This design also does not prevent anyone from creating a dinossaur without the factory. The client can instanciate a new dinossaur as he pleases */
            Triceratops trino = new Triceratops();
            trino.IsPredator = true;
            trino.NumberOfLegs = 6;
            trino.NumberOfTeeth = 3;
            /* So the client can create what he thinks is a triceratops. It might be something that looks straight out of Jason and the Argonauts. */

        }
    }
}
