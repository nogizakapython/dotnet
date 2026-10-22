using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[][] array1 = new int[][]
        {
            new int[]{1},
            new int[]{2,3},
            new int[]{4,5,6}
        };

        for(int i=0;i<3;i++){
            int n = array1[i].Length;
            Console.WriteLine(n);
        }
    }
}
