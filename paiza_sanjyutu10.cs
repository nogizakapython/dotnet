using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        int N = 10000;
        int A = Int32.Parse(array1[0]);
        int B = Int32.Parse(array1[1]);
        N /= A;
        N %= B;
        Console.WriteLine(N);
    }
}