using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Adiniz:");
            string? name = Console.ReadLine();
            Console.WriteLine("Soyadiniz:");
            string? surname = Console.ReadLine();

            Console.WriteLine("Hello " + name + " " + surname);

        }
    }
}