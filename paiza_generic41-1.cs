using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var array1 = Console.ReadLine().Split(' ');
        int n = int.Parse(array1[0]);
        int m = int.Parse(array1[1]);
        int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < array2.Length; i++)
        {
            if (i == m - 1) continue; // m番目はスキップ
            Console.WriteLine(array2[i]);
        }
    }
}