// See https://aka.ms/new-console-template for more information
using System;
namespace diziler
{
    class program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "kopek", "kuş", "maymun" };
            int[] dizi;
            dizi = new int[5];

            renkler[0] = "mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            Console.Write("Enter a number of elemaents of array:");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] numberArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter the {i} number");
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var number in numberArray)
            {
                toplam += number;
            }
            Console.WriteLine($"avarage:{toplam / arrayLength}");
        }
    }
}