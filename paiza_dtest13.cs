using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string line = Console.ReadLine();
        string[] array1 = line.Split(' ');
        foreach(string str1 in array1){
            Console.WriteLine(str1);
        }
    }
}
