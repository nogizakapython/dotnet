using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 入力例（long型を超える巨大な数値でもOK）
        string input = "1234567890123456789012345"; 

        // 3桁ごとに区切る位置を計算してカンマを挿入
        string result = InsertCommas(input);

        Console.WriteLine(result); 
        // 出力: 12,345,678,901,234,567,890,123,45
    }

    static string InsertCommas(string number)
    {
        // 先頭の桁数を計算（3の倍数でない場合の余り）
        int firstGroupLength = number.Length % 3;
        if (firstGroupLength == 0) firstGroupLength = 3;

        var sb = new System.Text.StringBuilder();
        
        // 最初のグループを追加
        sb.Append(number.Substring(0, firstGroupLength));

        // 残りの文字を3桁ずつ追加
        for (int i = firstGroupLength; i < number.Length; i += 3)
        {
            sb.Append(",");
            sb.Append(number.Substring(i, 3));
        }

        return sb.ToString();
    }
}