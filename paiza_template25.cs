using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int a = Int32.Parse(Console.ReadLine());
        output(a);
        var d = Console.ReadLine();
        var array1 = d.Split(' ');
        foreach(var data in array1){
            int num = Int32.Parse(data);
            output(num);
        }
        
    }
    static void output(int x){
        Console.WriteLine(x+1);
    }
}