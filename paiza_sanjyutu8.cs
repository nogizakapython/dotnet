using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        int N = 0;
        int A = Int32.Parse(array1[0]);
        int B = Int32.Parse(array1[1]);
        int C = Int32.Parse(array1[2]);
        N += A;
        N *= B;
        N %= C;
        Console.WriteLine(N);
    }
}