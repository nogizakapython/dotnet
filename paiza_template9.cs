using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string d = Console.ReadLine();
        var array1 = d.Split(" ");
        foreach(string s in array1){
            Console.WriteLine(s);
        }
    }
}
