using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int num1 = Int32.Parse(Console.ReadLine());
        int num2 = Int32.Parse(Console.ReadLine());
        int num3 = 100;
        int ans = (num3 - num2) * num1;
        System.Console.WriteLine(ans);
    }
}
