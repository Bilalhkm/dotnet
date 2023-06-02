class Program
{
    static void Main(string[] args)
    {
        Islemler operations = new();
        int baseNumber = 2;
        int exponent = 3;

        int result = operations.Expo(baseNumber, exponent);
        Console.WriteLine($"Result: {result}");
    }
}

public class Islemler
{
    public int Expo(int sayi, int us)
    {
        if (us == 1)
        {
            Console.Write($"{sayi}");
            return sayi;
        }
        Console.Write($"{sayi}x");
        return Expo(sayi, us - 1) * sayi;

    }
}