using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        string[] array1 = line.Split(',');
        foreach(string s in array1){
            Console.WriteLine(s);
        }
    }
}
