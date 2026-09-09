using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        char t = Console.ReadLine()[0];
        int l = s.IndexOf(t);

        Console.WriteLine(l+1);


    }
}
