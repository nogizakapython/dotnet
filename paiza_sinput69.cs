using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string ans = "";
        for(int i=0;i<10;i++){
            var line = Console.ReadLine();
            if(i < 9){
                ans += line + " ";
            } else {
                ans += line;
            }
        }
        Console.WriteLine(ans);
    }
}
