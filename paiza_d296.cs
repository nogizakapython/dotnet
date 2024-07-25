using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line1 = Console.ReadLine();
        var line2 = Console.ReadLine();
        int num1 = line1.Length;
        int num2 = line2.Length;
        if(num1 == num2){
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }
    }
}
