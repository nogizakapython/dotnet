using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string line = Console.ReadLine();
        string[] array1 = line.Split(' ');
        int A = Int32.Parse(array1[0]);
        int B = Int32.Parse(array1[1]);
        int H = Int32.Parse(Console.ReadLine());
        Console.WriteLine((A+B) * H / 2);
    }
}