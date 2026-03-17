using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string num = Console.ReadLine();
        int data;
        data = Int32.Parse(num);
        if(data < 10){
            num = "0" + num;
        }
        Console.WriteLine(num);
    }
}