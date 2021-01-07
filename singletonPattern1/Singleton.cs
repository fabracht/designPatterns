namespace singletonPattern1
{
    public sealed class Singleton
    {
        // A readonly can only be assigned within the scope of the constructor
        private static readonly Singleton _instance;
        private static int TotalInstances;

        /* 
        The private constructor is used to prevent the creation of instances with the 'new' keyword outside this class */

        private Singleton()
        {
            System.Console.WriteLine("Private constructor called");
        }

        /* With a private constructor, creating an instance from outside is now impossible, so we need a static constructor as well */
        static Singleton()
        {
            System.Console.WriteLine("This is the static constructor");
            _instance = new Singleton();
            TotalInstances++;
            System.Console.WriteLine($"Total number of instances: {TotalInstances}");
        }
        public static Singleton Instance => _instance;

        /* The following line shows one of the drawbacks of this approach to the singleton */
        public static int Myint = 25;
    }
}