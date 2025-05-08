using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        string[] array1 = new string[n];
        for(int i=0;i<n;i++){
            string data = Console.ReadLine();
            array1[i] = data;
        }
        Console.WriteLine(array1[7]);
    }
}
