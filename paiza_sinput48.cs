using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int N = Int32.Parse(Console.ReadLine());
        for(int i = 0; i < 5; i++)
        {
            N *= N;
        }
        Console.WriteLine(N);
    }
}