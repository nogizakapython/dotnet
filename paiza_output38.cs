using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        double n = Double.Parse(Console.ReadLine());
        string ans = n.ToString("0.000");
        
        Console.WriteLine(ans);
    }
}