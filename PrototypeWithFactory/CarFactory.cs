namespace PrototypeWithFactory
{

    /* INSTRUCTIONS ON HOW TO USE THIS CLASS
    There are three implementations of the CarFactory Class.
    The first is the simplest but it has the drawback of creating
    instances of the cars when they are not needed.
    The second implementation takes care of that. So, that would
    be our Lazy Initialization.
    The third is thread safe. We used the same strategy as we
    used for the Singleton class. We create a lock object that 
    we use in order to check if an instance of the car is being requested.
     */

    /* The following implementation of the CarFactory 
    instanciates the car types in the constructor.
    This has the drawback that for every instance of the
    factory, you create 2 instances of a BasicCar */
    // public class CarFactory
    // {
    //     private readonly BasicCar kia, ford;

    //     public CarFactory()
    //     {
    //         kia = new KiaCar("Green Kia");
    //         ford = new FordCar("Red Ford");
    //     }

    //     public BasicCar GetKia()
    //     {
    //         return kia.Clone();
    //     }

    //     public BasicCar GetFord()
    //     {
    //         return ford.Clone();
    //     }
    // }

    /* The following implementation only creates an instance
    of the cars when they are actually needed, i.e., when
    someone calls the factory functions. */
    // public class CarFactory
    // {
    //     private BasicCar kia, ford;
    //     public BasicCar GetKia()
    //     {
    //         if (kia != null)
    //         {
    //             // This means it has already been created
    //             return kia.Clone();
    //         }
    //         else
    //         {
    //             // Create it for the first time
    //             kia = new KiaCar("Green Kia");
    //             return kia;
    //         }
    //     }

    //     public BasicCar GetFord()
    //     {
    //         if (ford != null)
    //         {
    //             // A ford already exists
    //             return ford.Clone();
    //         }
    //         else
    //         {
    //             ford = new FordCar("Red Ford");
    //             return ford;
    //         }
    //     }
    // }

    public class CarFactory
    {
        private BasicCar kia, ford;

        // Again we go with the lock object to make things thread safe
        private object lockObject = new();

        public BasicCar GetKia()
        {
            if (kia == null)
            {
                lock (lockObject)
                {
                    if (kia == null)
                    {
                        kia = new KiaCar("Green Kia");
                    }
                }
            }
            return kia;
        }

        public BasicCar GetFord()
        {
            if (ford == null)
            {
                lock (lockObject)
                {

                    if (ford == null)
                    {
                        ford = new FordCar("Red Ford");
                    }
                }
            }
            return ford;
        }
    }
}