using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = new List<string>();
        var data1 = "Hello";
        var data2 = "paiza";
        var data3 = "1234";
        var data4 = "1234";
        array1.Add(data1);
        array1.Add(data2);
        array1.Add(data3);
        array1.Add(data4);
        Console.WriteLine(array1.Count);
    }
}