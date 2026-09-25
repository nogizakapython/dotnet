using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        var array1 = s.Split(',');
        foreach(var d in array1){
            Console.WriteLine(d);
        }
        //Console.WriteLine("XXXXXX");
    }
}
