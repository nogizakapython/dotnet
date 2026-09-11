using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        
        string s = Console.ReadLine();
        var d = Console.ReadLine();
        var array1 = d.Split(' ');
        int num  = Int32.Parse(array1[0]);
        char t = char.Parse(array1[1]);
        char[] array2 = s.ToArray();
        //Console.WriteLine(array2);
        array2[num-1] = t;
        var ans = "";
        foreach(char data in array2){
            ans += data;
        }
        Console.WriteLine(ans);
    }
}