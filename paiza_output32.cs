using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var data = Console.ReadLine();
        var array1 = data.Split(' ');
        int N = Int32.Parse(array1[0]);
        int M = Int32.Parse(array1[1]);
        string ans = "";
        for(int i=1;i<=N;i++){
            if(i == 1){
                ans = ans + i.ToString();
            } else {
                ans = ans + " " + i.ToString();
            }
        }
        Console.WriteLine(ans);
        ans = "";
        for(int j=1;j<=M;j++){
            if(j == 1){
                ans = ans + j.ToString();
            } else {
                ans = ans + " " + j.ToString();
            }
        }
        Console.WriteLine(ans);
        
    }
}