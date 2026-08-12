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
            for(int j=1;j<=N;j++){
                int d = i * j;
                if(j == 1){
                    ans = ans + d.ToString();
                } else {
                    ans = ans + " " + d.ToString();
                }
            }
            Console.WriteLine(ans);
            ans = "";
        }
        
    }
}