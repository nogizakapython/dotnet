using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // N, A, B をスペース区切りで標準入力から受け取る想定
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int a = int.Parse(input[1]);
        int b = int.Parse(input[2]);

        // (A, B) という文字列を N 個作成し、", " で結合して出力する
        string result = string.Join(", ", Enumerable.Repeat(string.Format("({0}, {1})", a, b), n));
        Console.WriteLine(result);
    }
}