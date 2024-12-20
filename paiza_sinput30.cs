using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var data = Console.ReadLine();
        string[] array1 = data.Split(' ');
        int length = array1.Length;
        for(int i=1;i<length;i++){
            Console.WriteLine(array1[i]);
        }
        //Console.WriteLine("XXXXXX");
    }
}