using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        ArrayList dataarray = new ArrayList();
        int num = 5;
        for(int i=0;i<num;i++){
            int number = Int32.Parse(Console.ReadLine());
            dataarray.Add(number);
        }
        int min_value = dataarray.Min();
        Console.WriteLine(min_value);
    }
}
