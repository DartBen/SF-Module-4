using System.Net.Cache;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        var anketa = (name:"",age:0);

        WriteLine("Введите имя:");
        anketa.name=ReadLine();
        WriteLine("Введите возраст:");
        int.TryParse( ReadLine(),out anketa.age);

        Console.WriteLine("Ваше имя: {0}", anketa.Item1);
        Console.WriteLine("Ваш возраст: {0}", anketa.Item2);
        Console.ReadKey();
    }
}

enum DaysOfWeek : byte
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}