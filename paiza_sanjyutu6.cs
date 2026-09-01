using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        int A = Int32.Parse(array1[0]);
        int B = Int32.Parse(array1[1]);
        int C = Int32.Parse(array1[2]);
        int D = Int32.Parse(array1[3]);
        double ans = Math.Pow((A+B)* C,2) % D;
        Console.WriteLine(ans);
    }
}
