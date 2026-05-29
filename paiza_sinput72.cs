using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        string[] array1 = line.Split(' ');
        string ans = "";
        foreach(string data in array1){
            ans = ans + data + ",";
                
        }
        Console.WriteLine(ans);
    }
}