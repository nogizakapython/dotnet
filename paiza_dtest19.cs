using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        int num1 = Int32.Parse(line);
        if(num1 <= 100){
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }
}
