using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        int b = 150;
        int ans = n / b;
        int mod = n % b;
        if(mod > 0){
            ans += 1;
        }
        Console.WriteLine(ans);
    }
}
