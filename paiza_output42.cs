using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        string ans = "";
        if ( n < 10){
            ans = n.ToString("000");
        } else if (n < 100){
            ans = n.ToString("000");
        } else {
            ans = n.ToString("000");
        }
        Console.WriteLine(ans);
    }
}