using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int p = Int32.Parse(Console.ReadLine());
        int x = Int32.Parse(Console.ReadLine());
        int ans = p - x;
        if(ans <= 0){
            Console.WriteLine(1);
        } else {
            Console.WriteLine(ans);
        }
        
    }
}