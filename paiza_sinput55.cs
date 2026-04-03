using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = "813, 1, 2, 923874, 23648, 782356, 3256, 2342, 24324, 112";
        var array1 = line.Split(',');
        foreach(var data in array1){
            Console.WriteLine(Int32.Parse(data));    
        }
        
    }
}