using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder("");
        for(int i=0;i<n;i++){
            string d = Console.ReadLine();
            sb.Append(d);
        }

        Console.WriteLine(sb);
        //Console.ReadKey();
    }
}
