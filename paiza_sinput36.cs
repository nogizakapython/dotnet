using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        string[] array1 = line.Split(' ');
        for(int i=1;i<array1.Length;i++){
            Console.WriteLine(array1[i]);
        }    
    }
}