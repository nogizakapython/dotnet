using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string ans = "";
        for(int i=0;i<3;i++){
            string data = Console.ReadLine();
            ans += data[0];
        }

        Console.WriteLine(ans);
    }
}
