using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var a = Console.ReadLine();
        var b = Console.ReadLine();
        var c = Console.ReadLine();
        var array1 = a.Split(' ');
        var array2 = b.Split(' ');
        var array3 = c.Split(' ');

        add_value(array1);
        add_value(array2);
        add_value(array3);
    }

    static void add_value(string[] w_array){
        var t_array = w_array;
        foreach(var num in t_array){
            int n = Int32.Parse(num);
            Console.WriteLine(n+1);
        }
    }
}
