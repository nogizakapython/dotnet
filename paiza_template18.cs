using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine(num1 + 1);
        var data2 = Console.ReadLine();
        var array2 = data2.Split(' ');
        foreach(var d_num2 in array2){
            int num2 = Int32.Parse(d_num2);
            Console.WriteLine(num2 + 1);
        }
        int num3 = Int32.Parse(Console.ReadLine());
        Console.WriteLine(num3 + 1);
    }
}