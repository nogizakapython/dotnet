using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        string[] array1 = line.Split(' ');
        int A = Int32.Parse(array1[0]) - Int32.Parse(array1[1]);
        int B = Int32.Parse(array1[0]) * Int32.Parse(array1[1]);
        Console.WriteLine(A.ToString() + " " + B.ToString());
    }
}
