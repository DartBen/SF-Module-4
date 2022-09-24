internal class Program
{
    private static void Main(string[] args)
    {

        Array arr = new int[2] { 1, 2 };
        int result = 0;

        foreach (int i in arr)
        {
            if (i > 0)
                result++; 

        }
        Console.WriteLine(result);
    }
}