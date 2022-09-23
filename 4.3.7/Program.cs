internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите своё имя");

        var name = Console.ReadLine();

        string nameResult="";

        Console.WriteLine("Ваше имя по буквам: ");
    
        for(int i= name.Length-1;i>=0 ;i--)
        {
            nameResult = string.Concat(nameResult, name[i]);

        }
        Console.WriteLine(nameResult);

    }
}