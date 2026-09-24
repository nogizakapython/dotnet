using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        bool ans = Regex.IsMatch(s,t);
        if(ans == true) {
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }
}
