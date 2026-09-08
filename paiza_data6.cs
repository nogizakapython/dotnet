using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        char t = Console.ReadLine()[0];
        int l = s.Length;
        for(int i=0;i<l;i++){
            char c = s[i];
            if(c == t){
                Console.WriteLine(i+1);
            }
        }

    }
}
