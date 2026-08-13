using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        string ans = "";
        for(int i = 1;i<= n;i++){
            for(int j = 1;j<= i ; j++){
                if(j == 1){
                    ans = ans + j.ToString();
                } else {
                    ans = ans +  " " + j.ToString();
                }
                //Console.WriteLine(ans);
                
            }
            Console.WriteLine(ans);
            ans = "";
        }
        //Console.WriteLine("XXXXXX");
    }
}