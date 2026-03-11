using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string s = Console.ReadLine();
        int l;
        l = s.Length;
        string ans;
        ans = "";
        for(int i=0;i<l;i++){
            string d;
            d = s[i].ToString();
            if((i != 0) && (i != l - 1)){
                ans += d;
            }
        }
        Console.WriteLine(ans);
    }
}
