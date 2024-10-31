using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string msg1 = "Hello paiza";
        var array1 = msg1.Split(' ');
        foreach(var msg in array1){
            Console.WriteLine(msg);
        }
    }
}
