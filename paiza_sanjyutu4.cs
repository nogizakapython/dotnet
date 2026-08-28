using System;

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
        int c = Int32.Parse(array1[2]);
        Console.WriteLine((a * a).ToString() + " " + ( b * b + c * c).ToString());
    }
}
