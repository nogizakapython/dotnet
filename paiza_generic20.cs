using System;

class Program
{
    static void Main()
    {
        // 2次元配列の宣言と初期化
        int[,] array2 = new int[,] {
            { 1, 2, 3, 4 },
            { 10, 100, 0, 5 },
            { 8, 1, 3, 8 },
            {15, 34, 94, 25}
        };
        
        var d = Console.ReadLine();
        var array1 = d.Split(' ');
        int k = Int32.Parse(array1[0]);
        int l = Int32.Parse(array1[1]);
        

        
        // 出力
        Console.WriteLine(array2[k-1,l-1]);
    }
}