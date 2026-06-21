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
        int count = 0;
        foreach(string data in array1){
            if(count < 9){
                ans = ans + data + ",";
            } else {
                ans = ans + data;
            }  
            count += 1;  
                
        }
        Console.WriteLine(ans);
    }
}