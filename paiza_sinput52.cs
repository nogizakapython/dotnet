using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string data = Console.ReadLine();
        string[] array1 = data.Split(' ');
        int N;
        int K;
        N = Int32.Parse(array1[0]);
        K = Int32.Parse(array1[1]);
        Console.WriteLine(N % K);
    }
}