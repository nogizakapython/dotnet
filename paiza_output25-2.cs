using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 入力を文字列として受け取る
        string n = Console.ReadLine();

        // 3 文字ずつ取り出してカンマで結合する
        var result = new StringBuilder();

        for (int i = 0; i < n.Length; i += 3)
        {
            // 最初以外の場合は前にカンマを入れる
            if (i > 0)
            {
                result.Append(',');
            }

            // 3 文字分を追加する
            result.Append(n.Substring(i, 3));
        }

        Console.WriteLine(result.ToString());
    }
}