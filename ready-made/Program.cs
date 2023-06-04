Console.WriteLine("Enter a sentence:");
string? input = Console.ReadLine();
string titleCase = input.ToUpper();
Console.WriteLine(titleCase);
string lowerCase = input.ToLower();
Console.WriteLine(lowerCase);
int length = input.Length;
Console.WriteLine(length);
bool contains = input.Contains("b");
Console.WriteLine(contains);
string substr = input.Substring(7);
Console.WriteLine(substr);
string replaced = input.Replace(substr, "masrs !");
Console.WriteLine(replaced);
string concatenated = string.Concat("by Bilal ", input);
Console.WriteLine(concatenated);

class Solution
{
    public static void Main(string[] args)
    {
        string S = Console.ReadLine();
        bool Conversion = int.TryParse(S, out int result);
        if (Conversion)
            Console.WriteLine(result);
        else
            Console.WriteLine("Bad String");
    }
}