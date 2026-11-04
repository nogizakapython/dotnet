using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var t = Console.ReadLine();
        var array1 = t.Split(' ');
        int n = Int32.Parse(array1[0]);
        int p = Int32.Parse(array1[1]);
        Console.WriteLine(n + 1);
        Console.WriteLine(p + 1);
        var u = Console.ReadLine();
        var array2 = u.Split(' ');
        int x = Int32.Parse(array2[0]);
        int y = Int32.Parse(array2[1]);
        int z = Int32.Parse(array2[2]);
        Console.WriteLine(x + 1);
        Console.WriteLine(y + 1);
        Console.WriteLine(z + 1);
        for(int i=0;i<n ; i++){
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine(d + 1);
        }
        
        //Console.WriteLine("XXXXXX");
    }
}