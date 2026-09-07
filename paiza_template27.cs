using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        var line2 = Console.ReadLine();
        var array2 = line2.Split(' ');
        foreach(var data in array1){
            int n = Int32.Parse(data);
            Console.WriteLine(n + 1);
        }
        foreach(var d in array2){
            int m = Int32.Parse(d);
            Console.WriteLine(m + 1);
        }

        //Console.WriteLine("XXXXXX");
    }
}
