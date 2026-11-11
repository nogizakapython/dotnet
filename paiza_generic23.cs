using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[] array1 = new int[10] {10,13,21,1,6,51,10,8,15,6};
        int count = 0;
        foreach(int num in array1){
            
            if( num == 6){
                count += 1;
            }
        }
        if(count > 0){
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }    
    }
}