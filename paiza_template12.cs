using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string data = Console.ReadLine();
        var array1 = data.Split(' ');
        foreach(var d in array1){
            int n = Int32.Parse(d);
            Console.WriteLine(n + 1);
        }
        
    }
}