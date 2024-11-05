using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        string[] array1 = line.Split(' ');
        foreach(string msg1 in array1){
            Console.WriteLine(msg1);    
        }
        
    }
}