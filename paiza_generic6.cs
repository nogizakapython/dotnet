using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        var d = Console.ReadLine();
        var array1 = d.Split(' ');
        foreach(var e in array1){
            int f = Int32.Parse(e);
            Console.WriteLine(f);
        }

    }
}
