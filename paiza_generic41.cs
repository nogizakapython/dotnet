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
        var array1 = line.Split(' ');
        int n = Int32.Parse(array1[0]);
        int m = Int32.Parse(array1[1]);
        int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var ans_list = new List<int>();
        ans_list = array2.ToList();
        ans_list.RemoveAt(m-1);
        foreach(int d in ans_list){
            Console.WriteLine(d);    
        }
        
    }
}