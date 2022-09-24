internal class Program
{
    private static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int sum_v1 = 0;
        int i;
        foreach (int z in arr)
        {
            sum_v1 += z;
        }

        Console.WriteLine(sum_v1);

        int sum_v2 = 0;
        for(i = 0; i < arr.Length ; i++)
        {
            sum_v2+= arr[i];
        }
        Console.WriteLine(sum_v2);
    }
}