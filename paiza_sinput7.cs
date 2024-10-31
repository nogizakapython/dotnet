using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = "one two three four five";
        var array1 = line.Split(' ');
        foreach(var msg in array1){
            Console.WriteLine(msg);
        }
    }
}
