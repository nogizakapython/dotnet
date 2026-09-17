using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string s = Console.ReadLine();
        string ans = "";
        int n = s.Length;
        for(int i=0;i<n;i++){
            char c = s[i];
            string str1 = "";
            
            if(char.IsUpper(c)){
                str1 = c.ToString();
                ans =  ans + str1.ToLower();
            } else {
                str1 = c.ToString();
                ans = ans + str1.ToUpper();
            }
        }
        Console.WriteLine(ans);
    }
}