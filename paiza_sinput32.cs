using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int num = Int32.Parse(Console.ReadLine());
        string data = Console.ReadLine();
        string[] array1 = data.Split(' ');
        foreach(string res in array1){
            Console.WriteLine(res);
        }    
    }
}