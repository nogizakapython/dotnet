using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[] array1 = new int[]{1,5,9,7,3,2,4,8,6,10};
        int l = array1.Length;
        int n = Int32.Parse(Console.ReadLine());
        
        for(int i=0;i<l;i++){
            int d = array1[i];
            if(d == n){
                Console.WriteLine(i + 1);        
            }
        }
        
    }
}