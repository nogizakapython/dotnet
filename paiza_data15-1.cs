using System;
using System.Text;

class Program
{
    static void Main()
    {
        // テスト用の入力文字列
        string s = Console.ReadLine();
        
        // 変換処理の実行
        string result = SwapCase(s);
        
        // 結果の出力
        Console.WriteLine("元の文字列: " + s);
        Console.WriteLine("変換後文字列: " + result);
    }

    static string SwapCase(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        // 文字列結合によるメモリ消費を抑えるため、StringBuilderを使用（C# 5対応）
        StringBuilder sb = new StringBuilder(input.Length);

        foreach (char c in input)
        {
            if (char.IsLower(c))
            {
                // 小文字なら大文字に変換
                sb.Append(char.ToUpper(c));
            }
            else if (char.IsUpper(c))
            {
                // 大文字なら小文字に変換
                sb.Append(char.ToLower(c));
            }
            else
            {
                // アルファベット以外（記号・数字・空白など）はそのまま保持
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}