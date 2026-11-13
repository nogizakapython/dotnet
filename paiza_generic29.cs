using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[] array1 = new int[] {1,2,2,1,2,1,2,1,1,1};
        int n = array1.Length;
        int count = 0;
        for(int i=0 ; i < n ; i++){
            int d = array1[i];
            if(d == 1){
                count += 1;
            }
        }
        Console.WriteLine(count);
    }
}