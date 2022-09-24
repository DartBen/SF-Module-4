using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };


        int temp;

        int a = arr.GetUpperBound(0);
        int b = arr.GetUpperBound(1);


        for (int y = 0; y < a+1; y++)
        {
            for (int z= 0; z < b; z++)
            {

                for (int i = 0; i < b; i++)
                {

                    if (arr[y,i] > arr[y,i + 1])
                    {
                        temp = arr[y,i];
                        arr[y,i] = arr[y,i + 1];
                        arr[y,i + 1] = temp;
                    };

                }
            }
        }

        foreach(int t in arr) Console.WriteLine(t);

    }
}