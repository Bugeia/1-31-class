using System;

namespace _1_31_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            try
            {
                string input = Console.ReadLine();

                Console.WriteLine(input);
            }
            catch
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }
        }
    }
}
