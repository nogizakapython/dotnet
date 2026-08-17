using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string n = Console.ReadLine();
        int l = n.Length;
        string ans;
        if(l == 1){
            ans = "  " + n;
        } else if (l == 2){
            ans = " " + n;
        } else {
            ans = n;
        }
        Console.WriteLine(ans);
    }
}