using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        int result1;
        if (int.TryParse(s, out result1)){
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }
}
