using System;
using System.Linq;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int tmp = array1[1];
        array1[1] = array1[0];
        array1[0] = tmp;
        Console.WriteLine(array1[0].ToString() + " " + array1[1].ToString());
    }
}