using System;

namespace singletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleSingleton singleton1 = ExampleSingleton.uniqueInstance();
            ExampleSingleton singleton2 = ExampleSingleton.uniqueInstance();

            singleton1.count = 10;
            System.Console.WriteLine(singleton2.count);
        }
    }
}
