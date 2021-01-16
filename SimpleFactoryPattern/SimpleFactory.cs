using System;

namespace SimpleFactoryPattern
{
    public class SimpleFactory
    {
        public IDinossaur CreateAnimal(EDinossaur choice)
        {
            IDinossaur dinossaur = null;
            System.Console.WriteLine("Internacional Genetics Systems");
            System.Console.WriteLine("Factory System - Site B");
            System.Console.WriteLine($"Creating a {choice.ToString()}");

            if (Enum.IsDefined(choice))
            {
                switch (choice)
                {
                    case EDinossaur.Velociraptor:
                        dinossaur = new Velociraptor();
                        dinossaur.IsPredator = true;
                        dinossaur.NumberOfLegs = 2;
                        dinossaur.NumberOfTeeth = 56;
                        break;
                    case EDinossaur.Triceratops:
                        dinossaur = new Triceratops();
                        dinossaur.IsPredator = false;
                        dinossaur.NumberOfLegs = 4;
                        dinossaur.NumberOfTeeth = 76;
                        break;
                    default:
                        System.Console.WriteLine("Invalid input. Please enter either 0 or 1");
                        throw new ApplicationException($"Unknown animal. This factory does not support animal of type {choice.ToString()}");
                }
            }
            return dinossaur;
        }

    }
}