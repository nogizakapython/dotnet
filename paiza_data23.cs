using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        int l = s.Length;
        var array1 = new List<string>();

        StringBuilder sb = new StringBuilder();

        for(int i=0 ; i < l;i++ ){
            char c = s[i];
            array1.Add(c.ToString());
        }

        var ans1 = array1.Distinct().ToList();
        foreach(var d in ans1){
            sb.Append(d);
        }
        Console.WriteLine(sb);
    }
}
