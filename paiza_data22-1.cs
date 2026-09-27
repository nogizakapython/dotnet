using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        //int result1;
        if (s.All(char.IsDigit)){
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }
}
