using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var data = Console.ReadLine();
        var array1 = data.Split(' ');
        foreach(var d in array1){
            Console.WriteLine(d);
        }    
    }
}