using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[] array1 = new int[]{1,10,2,9,3,8,4,7,5,6};
        int n = array1.Length;
        
        for(int i=0;i < n ; i++ ){
            int data = array1[i];
            if (data == 8){
                Console.WriteLine(i + 1);
            }    
        }    
    }
}