using System;
using System.Linq;


class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        int x = Int32.Parse(array1[0]);
        int y = Int32.Parse(array1[1]);
        int n = Int32.Parse(array1[2]);
        int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int tmp = array2[y-1];
        array2[y-1] = array2[x-1];
        array2[x-1] = tmp;
        foreach(int d in array2){
            Console.WriteLine(d);
        }
    }
}