using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[] array1 = new int[10]{5,12,6,84,14,25,44,3,7,20};
        int num = Int32.Parse(Console.ReadLine());
        int count = 0;
        foreach (int n in array1){
            if(n == num){
                count += 1;
            }
        }
        
        if (count > 0) {
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }    
    }
}