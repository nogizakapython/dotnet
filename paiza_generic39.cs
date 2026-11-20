using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var w_array = line.Split(' ');
        int n = Int32.Parse(w_array[0]);
        int m = Int32.Parse(w_array[1]);
        int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int count = 0;
        foreach(int t in array1){
            if(t == m){
                count += 1;
            }
        }
        Console.WriteLine(count);
    }
}