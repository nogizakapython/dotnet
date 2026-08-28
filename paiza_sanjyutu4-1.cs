using System;

class Program
{
    static void Main()
    {
        // 入力を読み込み、空白で分割します
        string[] input = Console.ReadLine().Split(' ');
        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);
        long c = long.Parse(input[2]);

        // 計算を行います（オーバーフローを防ぐため long 型を使用）
        long x = a * a;
        long y = b * b + c * c;

        // 結果を半角スペース区切りで出力します
        Console.WriteLine(x.ToString() + " " + y.ToString());
    }
}
