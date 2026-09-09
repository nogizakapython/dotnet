using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int ans = n / 150;

        if (n % 150 > 0)
        {
            ans++;
        }

        Console.WriteLine(ans);
    }
}
