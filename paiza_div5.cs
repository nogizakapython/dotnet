using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        int count = 0;
        
        for(int i = 0; i < n ; i++){
            int d = Int32.Parse(Console.ReadLine());
            array1[i] = d;
        }
        
        foreach(int data in array1){
            if (data == 0){
                count += 1;
            }
        }
        
        if(count == 0){
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }    
    }
}