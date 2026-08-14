using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        double n = Double.Parse(array1[0]);
        int s = Int32.Parse(array1[1]);
        string ans = "";
        switch(s){
            case 1:
             ans = n.ToString("0.0");
             break;
            case 2:
             ans = n.ToString("0.00");
             break;
            case 3:
             ans = n.ToString("0.000");
             break;
            case 4:
             ans = n.ToString("0.0000");
             break;
        }
        Console.WriteLine(ans);
    }
}