using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        int m = Int32.Parse(array1[0]);
        int n = Int32.Parse(array1[1]);
        int ans = m / n;
        Console.WriteLine(ans);
    }
}