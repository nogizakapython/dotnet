using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        string ans = "";
        for(int i=0;i<n;i++){
            ans += "*";
        }
        Console.WriteLine(ans);
    }
}
