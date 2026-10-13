using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        string ans = "";
        int leng = n - 2;
        char str1 = s[0];
        char end1 = s[n-1];
        ans = str1.ToString() + leng.ToString() + end1.ToString();
        Console.WriteLine(ans);
    }
}