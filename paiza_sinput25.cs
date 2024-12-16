using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int num1 = Int32.Parse(Console.ReadLine());
        string data = Console.ReadLine();
        string[] array1 = data.Split(' ');
        foreach(string n in array1){
            Console.WriteLine(n);
        }
    }
}
