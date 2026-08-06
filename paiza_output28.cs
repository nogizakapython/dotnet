using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        var array1 = s.Split(' ');
        string ans = "";
        for(int i=0;i<array1.Length;i++){
            if(i % 3 == 0){
                if( i > 0){
                    Console.WriteLine(ans);
                    ans = "";
                }    
                ans = ans + array1[i] + " ";
            } else if( i % 3 == 2){
                ans += array1[i];
            } else if ( i % 3 == 1){
                ans = ans + array1[i] + " ";
            }
        }
        Console.WriteLine(ans);
    }
}