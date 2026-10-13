using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        var s = Console.ReadLine();
        var array1 = s.Split(' ');
        Console.WriteLine(array1[n-1]);
    }
}