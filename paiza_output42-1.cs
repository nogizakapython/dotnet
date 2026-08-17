using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        string ans = "";
        ans = n.ToString("000");
        
        Console.WriteLine(ans);
    }
}