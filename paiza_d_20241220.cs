using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int num1 = Int32.Parse(Console.ReadLine());
        int ans1;
        int amari1;
        ans1 = num1 / 6;
        amari1 = num1 % 6;
        if(amari1 > 0) {
            ans1 += 1;
        }    
        Console.WriteLine(ans1);
    }
}