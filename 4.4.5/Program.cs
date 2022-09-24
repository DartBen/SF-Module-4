using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        (string Name, string Type, double Age, int NameCount) Pet;

        WriteLine("Введите имя питомца:");
        Pet.Name = ReadLine();
        WriteLine("Введите вид питомца:");
        Pet.Type = ReadLine();
        WriteLine("Введите возраст питомца:");
        double.TryParse(ReadLine(), out Pet.Age);
        Pet.NameCount = Pet.Name.Length;
    }
}