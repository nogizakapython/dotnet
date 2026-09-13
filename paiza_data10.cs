using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int x = Int32.Parse(Console.ReadLine());
        int y = Int32.Parse(Console.ReadLine());
        int n = Int32.Parse(Console.ReadLine());
        int ans = x + y;
        string a = ans.ToString();
        Console.WriteLine(a[n-1]);
    }
}
