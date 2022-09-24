using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        var (name, age) = ("Дмитрий", 32);
        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);


        //var anketa = (name: "", age: 0);

        WriteLine("Введите имя:");
        name = ReadLine();
        WriteLine("Введите возраст:");
        int.TryParse(ReadLine(), out age);

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);
        Console.ReadKey();
    }
}