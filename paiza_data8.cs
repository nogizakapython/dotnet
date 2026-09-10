using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        var data = Console.ReadLine();
        var array1 = data.Split(' ');
        int i = Int32.Parse(array1[0]);
        int j = Int32.Parse(array1[1]);
        string ans = s.Substring(i-1,j-i+1);
        Console.WriteLine(ans);
    }
}
