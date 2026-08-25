using System;


class Program
{
    static void Main()
    {
        // N, A, B をスペース区切りで標準入力から受け取る想定
        var input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        var a = input[1];
        var b = input[2];
        string ans = "";
        for(int i = 1; i <= n;i++)
        {
            if (i == n)
            {
                ans = ans + "(" + a + ", " + b + ")";
            } else
            {
                ans = ans + "(" + a + ", " + b + "),";
            }
        }

        Console.WriteLine(ans);
    }
}