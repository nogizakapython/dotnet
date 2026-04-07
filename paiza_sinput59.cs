using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        double A = long.Parse(array1[0]);
        double B = long.Parse(array1[1]);
        double C = long.Parse(array1[2]);
        double ans = (C / B);
        if(A > ans){
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }   
    }
}