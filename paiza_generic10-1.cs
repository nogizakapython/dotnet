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
        int leng1 = array1.Length;
        int num = 0;
        for(int i=0;i < leng1 ; i++)
        {
            num += array1[i].Length;
        }

        Console.WriteLine(num);
    }
}
