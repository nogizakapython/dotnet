using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var data1 = Console.ReadLine();
        var array1 = data1.Split(' ');
        int k = Int32.Parse(array1[0]);
        int l = Int32.Parse(array1[1]);
        int[,] array2 = new int[3,3];
        for(int i=0;i<3;i++){
            string[] array3= Console.ReadLine().Split(' ');
            for(int j=0;j<3;j++){
                array2[i,j] = Int32.Parse(array3[j]);
                
            }
            
        }
        
        
        Console.WriteLine(array2[k-1,l-1]);
    }
}