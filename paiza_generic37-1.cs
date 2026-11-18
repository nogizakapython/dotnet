using System;
using System.Linq;


class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] array2 = array1.OrderBy(p => p).ToArray();
        // Array.Sort(array1);
        foreach(int d in array2){
            Console.WriteLine(d);
        }    
    }
}