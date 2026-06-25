using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int h = Int32.Parse(Console.ReadLine());
        if(h >= 0 && h < 12) {
            Console.WriteLine("AM");
        } else if (h >= 12 && h < 24){
            Console.WriteLine("PM");
        }    
    }
}