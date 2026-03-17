using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int N = Int32.Parse(Console.ReadLine());
        if(N == 1){
            Console.WriteLine("A");
        } else if (N == 2){
            Console.WriteLine("B");
        } else if (N == 3){
            Console.WriteLine("C");
        } else if (N == 4){
            Console.WriteLine("D");
        } else {
            Console.WriteLine("E");
        }    
        //Console.WriteLine("XXXXXX");
    }
}