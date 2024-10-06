using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string line = Console.ReadLine();
        string[] array1 = line.Split(' ');
        int A,B,C;
        A = Int32.Parse(array1[0]);
        B = Int32.Parse(array1[1]);
        C = Int32.Parse(array1[2]);
        Console.WriteLine(A - B + C);
    }
}
