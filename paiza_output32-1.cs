using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var data = Console.ReadLine();
        var array1 = data.Split(' ');
        foreach(var d in array1)
        {
            int num = Int32.Parse(d);
            result1(num);
        }
        
    }
    static void result1(int num)
    {
        string ans = "";
        for(int i = 1; i <= num; i++)
        {
            if(i == 1)
            {
                ans = ans + i.ToString();
            } else
            {
                ans = ans + " " + i.ToString();
            }
        }
        Console.WriteLine(ans);
    }
}