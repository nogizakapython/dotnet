using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        string num3 = Console.ReadLine();
        int value1;
        int value2;
        int value3;
        int cost;
        value1 = Int32.Parse(num1);
        value2 = Int32.Parse(num2);
        value3 = Int32.Parse(num3);
        cost = value1 * value2 * value3;
        Console.WriteLine(cost);
    }
}