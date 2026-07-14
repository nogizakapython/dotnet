using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var data = Console.ReadLine();
        var array1 = data.Split(' ');
        int[] array2 = new int[2];
        for(int i=0;i<2;i++){
            array2[i] = Int32.Parse(array1[i]) + 1;
        }
        foreach(int d in array2){
            Console.WriteLine(d);
        }    
    }
}