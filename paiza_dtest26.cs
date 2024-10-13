using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string num1 = Console.ReadLine();
        int num = Int32.Parse(num1);
        for(int i=0;i < num;i++){
            var line = Console.ReadLine();
            Console.WriteLine(line);
        }
    }
}
