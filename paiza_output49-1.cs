using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        int H = Int32.Parse(array1[0]);
        int W = Int32.Parse(array1[1]);
        string A = array1[2];
        string B = array1[3];

        // 1つの要素となる文字列を作成 例: "(1, 2)"
        string element = string.Format("({0}, {1})", A, B);

        // 1行分の文字列を作成 (指定された要素をW個、" | " で結合)
        string rowStr = string.Join(" | ", Enumerable.Repeat(element, W));

        // 上の行と同じ文字数の '=' 区切り線を作成
        string separator = new string('=', rowStr.Length);

        // H行分出力
        for (int i = 0; i < H; i++)
        {
            // 2行目以降の前に区切り線を出力
            if (i > 0)
            {
                Console.WriteLine(separator);
            }
            
            // 行の文字列を出力
            Console.WriteLine(rowStr);
        }
    }
}