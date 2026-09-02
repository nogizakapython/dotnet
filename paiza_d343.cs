using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        int k = Int32.Parse(Console.ReadLine());
        string ans = s.Substring(0,k);
        Console.WriteLine(ans);
    }
}