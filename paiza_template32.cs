using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        int n = Int32.Parse(array1[0]);
        int m = Int32.Parse(array1[1]);
        int k = Int32.Parse(array1[2]);
        Console.WriteLine(n+1);
        Console.WriteLine(m+1);
        Console.WriteLine(k+1);
        for(int i=0;i<m;i++){
            int data = Int32.Parse(Console.ReadLine());
            Console.WriteLine(data + 1);    
        }
        
    }
}