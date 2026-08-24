using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int max_t = 0;
        for(int i=0;i<3;i++){
            int d = Int32.Parse(Console.ReadLine());
            
            if (d >= max_t){
                max_t = d;
            }
        }
        
        Console.WriteLine(max_t);
    }
}