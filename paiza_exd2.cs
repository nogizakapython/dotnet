using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string data1 = Console.ReadLine();
        string[] array1 = data1.Split(' ');
        int a = Int32.Parse(array1[0]);
        int b = Int32.Parse(array1[1]);
        Console.WriteLine(a + b);
    }
}
