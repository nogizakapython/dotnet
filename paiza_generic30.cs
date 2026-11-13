using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        int[] array1 = new int[]{1,2,5,1,4,3,2,5,1,4};
        int l = array1.Length;
        int count = 0;
        for(int i=0 ; i < l ; i++){
            int d = array1[i];
            if( d == n){
                count += 1;
            }
        }
        Console.WriteLine(count);
    }
}