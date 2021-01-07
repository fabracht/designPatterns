using System;

namespace singletonPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Singleton Pattern Demonstration.***");

            /* Because we can't use new() to instanciate our singleton, we have to go through the getter */
            // Singleton s1 = Singleton.Instance;
            /* Notice that the next line does not produce any output */
            // Singleton s2 = Singleton.Instance;

            // if (s1.Equals(s2))
            // {
            //     Console.WriteLine("s1 and s2 are the same.");
            // }
            // else
            // {
            //     Console.WriteLine("Different instances exist.");
            // }


            /* **************************** */
            /* This next line shows a caveat with this design. If you want to access the static variable within the class, it will create an instance of the Singleton class */
            System.Console.WriteLine(Singleton.Myint);
        }
    }
}
