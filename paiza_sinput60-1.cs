using System;

class Program
{
    static void Main()
    {
        // 入力:
        // 1行目: N
        // 2行目: S
        // 3行目: T
        int N = int.Parse(Console.ReadLine());
        string S = Console.ReadLine();
        string T = Console.ReadLine();

        if (IsGreater(S, T))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    static bool IsGreater(string s, string t)
    {
        // 桁数が異なれば、桁数が大きい方が大きい
        if (s.Length != t.Length)
        {
            return s.Length > t.Length;
        }

        // 桁数が同じなら辞書順比較
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != t[i])
            {
                return s[i] > t[i];
            }
        }

        // 完全一致なら s > t ではない
        return false;
    }
}