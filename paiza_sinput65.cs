using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string line = Console.ReadLine();
        var array1 = line.Split(' ');
        
        foreach(var s in array1){
            Console.WriteLine(s);
           
        }
        
    }
}