using System;
namespace methods
{
    class program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(Topla(a, b));
            Methods yazdir = new Methods();
            yazdir.print($"{Topla(a, b)}");
        }
        static int Topla(int a, int b)
        {
            return (a + b);
        }

    }
    class Methods
    {
        public void print(string message)
        {
            Console.WriteLine(message);
        }
    }
}