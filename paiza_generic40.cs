using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[] w_array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = w_array[0];
        int m = w_array[1];
        int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] array2 = array1.Append(m).ToArray();
        
        foreach(int e in array2){
            Console.WriteLine(e);    
        }
        
    }
}