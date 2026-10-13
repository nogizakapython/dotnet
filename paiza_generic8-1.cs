using System;

class Program
{
    static void Main()
    {
        // 1行目から N と K を取得
        var s = Console.ReadLine();
        var array1 = s.Split(' ');
        int N = Int32.Parse(array1[0].ToString());
        int K = Int32.Parse(array1[1].ToString());

        // 2行目から N 個の整数を配列として取得
        var t = Console.ReadLine();
        var array2 = t.Split(' ');
        

        // K 番目の整数を出力（配列のインデックスは0から始まるため K-1）
        Console.WriteLine(array2[K - 1]);
    }
}