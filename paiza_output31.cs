using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int N = Int32.Parse(Console.ReadLine());
        string ans = "";
        for(int i=1;i<=N;i++){
            if((i == N /2) || (i == N)){
                ans = ans + " " + i.ToString();
                Console.WriteLine(ans);
                ans = "";
            } else if ((i == 1) || (i == N/2 + 1)){
                ans = ans + i.ToString();
            } else {
                ans = ans + " " + i.ToString();
            }
        }
        
    }
}