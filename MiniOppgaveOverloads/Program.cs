using System;

namespace OverloadTest
{
    internal class Program
    {
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Hei og velkommen.");
        }

        static void PrintWelcomeMessage(string name)
        {
            Console.WriteLine($"Hei {name} og velkommen.");
        }

        static void Main()
        {
            PrintWelcomeMessage("Tor");
        }
    }
}
