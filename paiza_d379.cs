using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int N = Int32.Parse(Console.ReadLine());
        if(N >= 100){
            Console.WriteLine("DANGER");
        } else {
            Console.WriteLine(N);
        }
        // Console.WriteLine("XXXXXX");
    }
}