using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        List<int> array1 = new List<int> {1,3,5,4,6,2,1,7,1,5};
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine(array1[n-1]);
    }
}
