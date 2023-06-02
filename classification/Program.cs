using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the number of words
        Console.WriteLine("Enter the number of words you want to enter:");
        int.TryParse(Console.ReadLine(), out int numOfWords);

        // Prompt the user to enter the words
        Console.WriteLine($"Enter {numOfWords} words:");
        string[] words = Console.ReadLine().Split(' ');

        Console.WriteLine();

        // Display the entered words
        Console.WriteLine("Entered words:");
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();

        // Display the words in reverse order
        Console.WriteLine("Words in reverse order:");
        for (int z = numOfWords - 1; z >= 0; z--)
        {
            Console.Write(words[z] + " ");
        }
        Console.WriteLine();

        // Prompt the user to enter the number of positive numbers
        Console.WriteLine("Enter the number of positive numbers you want to input:");
        int.TryParse(Console.ReadLine(), out int numOfNum);

        // Prompt the user to enter the positive numbers
        Console.WriteLine($"Enter {numOfNum} positive numbers:");
        string[] stNumbers = new string[numOfNum];
        stNumbers = Console.ReadLine().Split(' ');

        // Create an array to store the entered numbers
        int[] numbers = new int[stNumbers.Length];

        // Prompt the user to enter a number for comparison
        Console.WriteLine("Enter a number to check if the previously entered numbers are equal to or divisible by it:");
        int.TryParse(Console.ReadLine(), out int m);

        int i = 0;

        try
        {
            // Find and display positive even numbers among the entered numbers
            Console.WriteLine("Positive even numbers entered:");
            foreach (string stNumber in stNumbers)
            {
                numbers[i] = int.Parse(stNumber);
                if (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
                i++;
            }
            Console.WriteLine();
        }
        catch (Exception err)
        {
            Console.WriteLine($"Error: {err.Message}");
        }

        try
        {
            // Check if each number is divisible by or equal to the entered number
            Console.WriteLine("Numbers that are equal to or divisible by the entered number:");
            foreach (int num in numbers)
            {
                if (num % m == 0)
                {
                    Console.WriteLine($"The number {num} is divisible by {m}");
                }
                if (num == m)
                {
                    Console.WriteLine($"The number {num} is equal to {m}");
                }
            }
        }
        catch (Exception err)
        {
            Console.WriteLine($"Error: {err.Message}");

        }
    }
}
