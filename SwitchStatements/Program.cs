using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch and case statements in C#
            int temperature = 25;

            switch(temperature)
            {
                case 15:
                    Console.WriteLine("Not too hot, not too cold");
                    break;
                case 25:
                    Console.WriteLine("Warm as!");
                    break;
                default:
                    Console.WriteLine("How warm is it then?");
                    break;
            }

            // Reproduce above as an if statement
            if (temperature == 25)
            {
                Console.WriteLine("Warm as");
            } 
            else if (temperature == 15)
            {
                Console.WriteLine("Not too hot, not too cold.");
            } 
            else
            {
                Console.WriteLine("How warm is it then?");
            }

            // Switch using strings
            string username = "Adam";

            switch (username)
            {
                case "Adam":
                    Console.WriteLine("Username is Adam.");
                    break;
                case "Paul":
                    Console.WriteLine("Username is Paul.");
                    break;
                default:
                    Console.WriteLine("Unknown username.");
                    break;
            }
        }
    }
}
