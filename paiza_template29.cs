using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        int n = Int32.Parse(array1[0]);
        int b = Int32.Parse(array1[1]);
        int c = Int32.Parse(array1[2]);
        Console.WriteLine(n + 1);
        Console.WriteLine(b + 1);
        Console.WriteLine(c + 1);
        for(int i=0;i<n;i++){
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine(d + 1);
        }
    }
}