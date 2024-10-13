using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string data1 = Console.ReadLine();
        string[] array1 = data1.Split(' ');
        foreach(string msg in array1){
            Console.WriteLine(msg);
        }
    }
}
