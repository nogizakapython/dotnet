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
        for(int i=0;i<n;i++){
            string ans = "";
            int d = Int32.Parse(Console.ReadLine());
            ans = d.ToString().PadLeft(m);
            Console.WriteLine(ans);
        }
        //Console.WriteLine("XXXXXX");
    }
}