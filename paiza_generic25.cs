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
        int n = Int32.Parse(array1[0]);
        int m = Int32.Parse(array1[1]);
        int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool flag1 = array2.Contains(m);
        if (flag1){
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }    
    }
}