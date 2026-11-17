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
        for(int i = x-1;i < y;i++){
            Console.WriteLine(array2[i]);    
        }
        
    }
}