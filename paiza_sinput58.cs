using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        char[] array1 = s.ToCharArray();
        int score = 0;
        for(int i=0;i<n;i++){
            char d = array1[i];
            if(d == 'o'){
                score += 10;
            }
        }
        Console.WriteLine(score);
    }
}