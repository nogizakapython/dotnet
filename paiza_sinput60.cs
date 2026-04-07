using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        long N = long.Parse(Console.ReadLine());
        long S = long.Parse(Console.ReadLine());
        long T = long.Parse(Console.ReadLine());
        long ans = S - T;
        if(ans > 0){
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");    
        }
        
    }
}