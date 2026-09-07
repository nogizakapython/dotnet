using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1行目: A, B を取得してそれぞれ +1 して出力
        string[] line1 = Console.ReadLine().Split();
        int a = int.Parse(line1[0]);
        int b = int.Parse(line1[1]);
        Console.WriteLine("{0} {1}", a + 1, b + 1);

        // 2行目: N を取得して +1 して出力
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n + 1);

        // 3行目: N個の整数を取得し、それぞれ +1 してスペース区切りで出力
        string[] line3 = Console.ReadLine().Split();
        var aList = line3.Select(x => int.Parse(x) + 1);
        Console.WriteLine(string.Join(" ", aList));
    }
}
