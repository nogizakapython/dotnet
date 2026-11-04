using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string[] array1 = Console.ReadLine().Split(' ');
        int n = Int32.Parse(array1[0]);
        int m = Int32.Parse(array1[1]);
        int k = Int32.Parse(array1[2]);
        int l = Int32.Parse(array1[3]);
        int[,] array2 = new int[n,m];
        for(int i =0 ; i< n;i++){
            string[] array3 = Console.ReadLine().Split(' ');
            for(int j = 0;j<l;j++){
                array2[i,j] = Int32.Parse(array3[j]);
            }
        }
        Console.WriteLine(array2[k-1,l-1]);
    }
}