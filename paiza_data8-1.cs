using System;

class Program
{
    static void Main()
    {
        string S = "abcdefg";
        int i = 2; // 2文字目 (b)
        int j = 5; // 5文字目 (e)

        // i番目(1-indexed)から j - i + 1 文字を取得
        string result = S.Substring(i - 1, j - i + 1);

        Console.WriteLine(result); // bcde 出力
    }
}
