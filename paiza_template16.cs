using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        foreach(var data in array1){
            double d = double.Parse(data);
            Console.WriteLine(d + 0.1);    
        }
        
    }
}