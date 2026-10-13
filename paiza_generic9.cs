using System;

class Program
{
    static void Main()
    {
        // 1行目から N と K を取得
        string[] firstLine = Console.ReadLine().Split(' ');
        int N = int.Parse(firstLine[0]);
        int K = int.Parse(firstLine[1]);

        // 2行目から N 個の整数を配列として取得
        string[] secondLine = Console.ReadLine().Split(' ');
        int[] a = new int[N];
        for (int i = 0; i < N; i++)
        {
            a[i] = int.Parse(secondLine[i]);
        }

        // K 番目の整数を出力（配列のインデックスは0から始まるため K-1）
        Console.WriteLine(a[K - 1]);
    }
}