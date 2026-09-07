using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1行目: N, M を取得してそれぞれ +1 して出力
        string[] line1 = Console.ReadLine().Split();
        int n = int.Parse(line1[0]);
        int m = int.Parse(line1[1]);
        Console.WriteLine("{0} {1}", n + 1, m + 1);

        // 2行目: N個の整数を取得し、それぞれ +1 してスペース区切りで出力
        string[] line2 = Console.ReadLine().Split();
        var aList = line2.Select(x => int.Parse(x) + 1);
        Console.WriteLine(string.Join(" ", aList));
    }
}
