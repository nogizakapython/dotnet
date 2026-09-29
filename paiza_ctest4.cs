using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        List<int> array1 = new List<int>();
        for(int i = 0 ; i < n ; i++){
            int d = Int32.Parse(Console.ReadLine());
            array1.Add(d);
        }
        Console.WriteLine(array1.Max());
    }
}