using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string ans = "";
        for(int i=1;i<10;i++){
            for(int j=1;j<10;j++){
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