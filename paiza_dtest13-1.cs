using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string line = Console.ReadLine();
        string[] array1 = line.Split(' ');
        int leng1 = array1.Length;
        for(int i=0;i<leng1;i++){
            Console.WriteLine(array1[i]);
        }
    }
}