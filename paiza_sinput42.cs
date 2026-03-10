using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string[] array1 = Console.ReadLine().Split(' ');
        double a = Double.Parse(array1[0]);
        double b = Double.Parse(array1[2]);
        // Console.WriteLine(a);
        // Console.WriteLine(b);
        int ans = (int)((b / a) * 100);
        Console.WriteLine(ans);
    }
}