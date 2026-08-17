using System;

class Program
{
    static void Main(string[] args)
    {
        // N を入力
        int N = int.Parse(Console.ReadLine());

        // N 個の数値を処理
        for (int i = 0; i < N; i++)
        {
            int M = int.Parse(Console.ReadLine());
            // 3桁になるよう右寄せ（前に半角スペースを埋める）
            Console.WriteLine(M.ToString().PadLeft(3));
        }
    }
}