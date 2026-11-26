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

        // インデックスが m-1 以外の要素だけを残す
        array2 = array2.Where((x, i) => i != m - 1).ToArray();

        foreach (int d in array2)
        {
            Console.WriteLine(d);
        }
    }
}