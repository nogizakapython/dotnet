using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[][] array1 = new int[][]
            {
                new int[]{1,2,3,4,5,6},
                new int[]{8,1,3,3,1,8}

            };

        int ans1 = array1[0].Length;
        int ans2 = array1[1].Length;
        Console.WriteLine(ans1 + ans2);
    }
}
