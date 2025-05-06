using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int line = Int32.Parse(Console.ReadLine());
        string[] array1 = new string[line];
        for(int i=0;i<line;i++){
            array1[i] = Console.ReadLine();
        }
        Console.WriteLine(array1[7]);
    }
}
