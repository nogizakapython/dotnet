using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. 文字列 S を入力から受け取る
        var s = Console.ReadLine();
        if (s == null) return;

        // 2. LINQ の Distinct() を使って、左から順に重複した文字を削除する
        // 3. ToArray() で文字の配列 (char[]) に変換する
        char[] uniqueChars = s.Distinct().ToArray();

        // 4. 文字配列を新しい文字列に変換して出力する
        Console.WriteLine(new string(uniqueChars));
    }
}
