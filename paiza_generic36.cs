using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var d = Console.ReadLine();
        var array1 = d.Split(' ');
        int m = Int32.Parse(array1[0]);
        int n = Int32.Parse(array1[1]);
        int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] array3 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] result = array2.Concat(array3).ToArray();
        foreach(int e in result){
            Console.WriteLine(e);
            
        }
        //Console.WriteLine("XXXXXX");
    }
}