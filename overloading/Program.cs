string num = Console.ReadLine();
bool result = int.TryParse(num, out int outsayi);
if (result)
{
    Console.WriteLine($"the number is added successfully{outsayi}");
}
else
{
    Console.WriteLine("failed");
}

Methods instance = new Methods();
instance.Add(2, 3, out int numToplam);
Console.WriteLine(numToplam);

 class Methods
{
    public void Add(int a, int b, out int toplam)
    {
        toplam = a + b;
    }
    public void print(string  veri){
        Console.WriteLine(veri);
    }
    public void print(int  veri){
        Console.WriteLine(veri);
    }
}