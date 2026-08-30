using System;

public class Program
{
    public static void Main()
    {
        // 標準入力から1行取得
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return;

        // 半角スペースで各項に分割
        string[] terms = input.Split(' ');

        // 各項に対して判定と出力を行う
        foreach (string term in terms)
        {
            int number;
            // 整数に変換できる場合は +1 して出力
            if (int.TryParse(term, out number))
            {
                Console.WriteLine(number + 1);
            }
            // 整数でない（文字などの）場合はそのまま出力
            else
            {
                Console.WriteLine(term);
            }
        }
    }
}
