using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string s = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        int l = s.Length;
        for(int i = l - 1;i >= 0;i--){
            char data = s[i];
            sb.Append(data);
        }
        Console.WriteLine(sb);
    }
}
