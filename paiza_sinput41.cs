using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string s = Console.ReadLine();
        int n = s.Length;
        
        Console.WriteLine(s.Substring(n-1));
    }
}