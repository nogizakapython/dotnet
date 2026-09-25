using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string s = Console.ReadLine();
        string ans = "";
        int l = s.Length;
        for(int i = l - 1 ;i>= 0;i--){
            char d = s[i];
            ans += d.ToString();
        }
        if ( s == ans){
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }
}
