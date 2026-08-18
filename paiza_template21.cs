using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        int n = Int32.Parse(array1[0]) + 1;
        var s = array1[1];
        var t = array1[2];
        Console.WriteLine(n);
        Console.WriteLine(s);
        Console.WriteLine(t);
    }
}