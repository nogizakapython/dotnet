using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string s = Console.ReadLine();
        var array1 = s.Split(' ');
        foreach(var chr in array1){
            Console.WriteLine(chr);
        }    
    }
}