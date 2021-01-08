using System;

namespace SingletonWithLock
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonWithLocks instance1 = SingletonWithLocks.Instance;
            SingletonWithLocks instance2 = SingletonWithLocks.Instance;

            if (instance1.Equals(instance2))
            {
                System.Console.WriteLine("Instances are indeed the same");
            }
            else
            {
                System.Console.WriteLine("Instances are not the same, this is not a singleton");
            }
        }
    }
}
