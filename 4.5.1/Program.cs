using System.Reflection.Metadata;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        (string Name, string LastName, double Age, string login, int loginLenght, bool hasPets, string[] favoriteColors) User;
        string tempString;

        for (int z = 0; z < 3; z++)
        {
            Console.WriteLine("Введите имя");
            User.Name = ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = ReadLine();

            Console.WriteLine("Введите логин");
            User.login = ReadLine();
            User.loginLenght = User.login.Length;

            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            tempString = ReadLine();

            //User.hasPets = tempString == "Да" ? true : false ;

            if (tempString == "Да")
            {
                User.hasPets = true;
            }
            else if (tempString == "Нет")
            {
                User.hasPets = false;
            }

            Console.WriteLine("Введите возраст пользователя");
            double.TryParse(ReadLine(), out User.Age);


            User.favoriteColors = new string[3];

            Console.WriteLine("Введите три любимых цвета пользователя");
            for (int i = 0; i < User.favoriteColors.Length; i++)
            {
                User.favoriteColors[i] = ReadLine();
            }

        }
    }
}