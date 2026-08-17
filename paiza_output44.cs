using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        string ans = "";
        int n = Int32.Parse(array1[0]);
        int m = Int32.Parse(array1[1]);
        ans = n.ToString().PadLeft(m);
        Console.WriteLine(ans);
    }
}