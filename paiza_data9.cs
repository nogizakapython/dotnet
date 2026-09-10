using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        StringBuilder sb = new StringBuilder("");
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        int l = Int32.Parse(Console.ReadLine());
        sb.Append(s);
        sb.Insert(l,t);
        Console.WriteLine(sb);
    }
}
