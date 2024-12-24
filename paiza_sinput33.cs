using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string data1 = Console.ReadLine();
        string[] array1 = data1.Split(' ');
        for(int i=1;i<array1.Length;i++){
            Console.WriteLine(array1[i]);
        }    
    }
}