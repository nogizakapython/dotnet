using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string ans = "";
        for(int i = 1;i< 1001;i++){
            if(i < 1000){
                ans = ans + i.ToString() + " ";
            } else {
                ans = ans + i.ToString();
            }
        }

        Console.WriteLine(ans);
    }
}
