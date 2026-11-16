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
        int a = Int32.Parse(array1[0]);
        int b = Int32.Parse(array1[1]);
        int m = Int32.Parse(array1[2]);
        int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int l = array2.Length;
        for(int i = 0;i < l ; i++){
            int d = array2[i];
            if(d == a){
                array2[i] = b;
            }
            Console.WriteLine(array2[i]);
        }
        //Console.WriteLine("XXXXXX");
    }
}