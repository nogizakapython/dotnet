using System;

class Program
{
    static void Main()
    {
        // 1行目: N, M を読み込む（今回は a_1 ... a_N の処理に N を使用）
        string[] firstLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]); // 必要に応じて利用
        Console.WriteLine(n + 1);
        Console.WriteLine(m + 1);

        // 2行目: A, B, C を読み込む（問題文の仕様に合わせて受け取る）
        string[] secondLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int a = int.Parse(secondLine[0]);
        int b = int.Parse(secondLine[1]);
        int c = int.Parse(secondLine[2]);
        Console.WriteLine(a + 1);
        Console.WriteLine(b + 1);
        Console.WriteLine(c + 1);

        // 続く N 行で a_1, a_2, ..., a_N が改行区切りで与えられる
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            if (line != null)
            {
                int val = int.Parse(line);
                // 各値に +1 して出力
                Console.WriteLine(val + 1);
            }
        }
    }
}
