using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 入力例（3の倍数の桁数であれば、何百桁でも対応可能）
        string input = Console.ReadLine(); 

        // 3桁ずつの文字列を格納するリスト
        List<string> chunks = new List<string>();

        // 3文字ずつループを回してリストに追加する
        for (int i = 0; i < input.Length; i += 3)
        {
            // i番目の位置から3文字切り出す
            string part = input.Substring(i, 3);
            chunks.Add(part);
        }

        // リストの要素をカンマ（,）で結合する
        string result = string.Join(",", chunks);

        // 出力: 
        Console.WriteLine(result);
    }
}
