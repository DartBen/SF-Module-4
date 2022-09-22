internal class Program
{
    private static void Main(string[] args)
    {
        string a = "Aa";
        string b = "Bb";
        bool test = (a==b);
        Console.WriteLine($"результат {a}=={b} = {test}");

        a = "Aa";
        b = "Aa";
        test = (a == b);
        Console.WriteLine($"результат {a}=={b} = {test}");
        Console.ReadKey();

    }
}