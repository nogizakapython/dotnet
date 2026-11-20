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
        int l = array1.Length;
        for(int i = l - 1;i > -1;i--){
            Console.WriteLine(array1[i]);
        }
        //Console.WriteLine("XXXXXX");
    }
}