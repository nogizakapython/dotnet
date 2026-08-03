using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        List<char> array1 = s.ToList();
        int leng = s.Length;
        var ans = "";
        for(int i = leng - 3;i>0;i = i - 3){
            array1.Insert(i,',');
        }
        foreach(char c in array1){
            ans += c;
        }
        Console.WriteLine(ans);
    }    
}