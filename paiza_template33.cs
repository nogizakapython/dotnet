using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        int n = s.Length;
        int ans = 0;
        
        for(int i=0 ; i < n ; i++){
            if (( i % 2 == 0) && (i > 0)){
                char flag1;
                flag1 = s[i - 1];
                if (flag1 == '+') {
                    ans += Int32.Parse(s[i].ToString());
                } else {
                    ans -= Int32.Parse(s[i].ToString());
                }
            } else if ( i == 0){
                ans = Int32.Parse(s[i].ToString());
            }
        }
        Console.WriteLine(ans);
    }
}