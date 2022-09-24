internal class Program
{
    private static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

        int temp;

        foreach (int z in arr) { Console.Write(z + ""); }
        Console.WriteLine("");


        for (int y = 0; y < arr.Length - 1; y++)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] > arr[i+1])
                {
                    temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i + 1] = temp;
                };

                Console.WriteLine($"{y},{i}");
                foreach (int j in arr) { Console.Write(j + ""); }
                Console.WriteLine("");
            }
        }
    }
}