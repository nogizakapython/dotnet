using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line1 = Console.ReadLine();
        var line2 = Console.ReadLine();
        var array1 = line1.Split(' ');
        var array2 = line2.Split(' ');
        foreach(var data1 in array1){
            int d = Int32.Parse(data1);
            Console.WriteLine(d + 1);
        }
        foreach(var data2 in array2){
            int d2 = Int32.Parse(data2);
            Console.WriteLine(d2 + 1);
        }
    }
}