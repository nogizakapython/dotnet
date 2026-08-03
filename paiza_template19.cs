using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        
        var data1 = Console.ReadLine();
        var array1 = data1.Split(' ');
        var data2 = Console.ReadLine();
        var array2 = data2.Split(' ');
        var data3 = Console.ReadLine();
        var array3 = data3.Split(' ');
        var data4 = Console.ReadLine();
        var array4 = data4.Split(' ');
        foreach(var d1 in array1){
            int num1 = Int32.Parse(d1);
            Console.WriteLine(num1 + 1);
        }
        foreach(var d2 in array2){
            int num2 = Int32.Parse(d2);
            Console.WriteLine(num2 + 1);
        }
        foreach(var d3 in array3){
            int num3 = Int32.Parse(d3);
            Console.WriteLine(num3 + 1);
        }
        foreach(var d4 in array4){
            int num4 = Int32.Parse(d4);
            Console.WriteLine(num4 + 1);
        }
        
        
    }
}