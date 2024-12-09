using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string line = Console.ReadLine();
        var array1 = line.Split(' ');
        int count = array1.Length;
        for(int i=1;i<count;i++){
            Console.WriteLine(array1[i]);
        }
        //Console.WriteLine("XXXXXX");
    }
}
