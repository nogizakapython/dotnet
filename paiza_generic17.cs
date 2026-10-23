using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        
        
        
        int n = Int32.Parse(Console.ReadLine());
        int[,] array1 = new int[5,n];
        string ans = "";
        
        for(int i = 0;i<5;i++){
            var data = Console.ReadLine();
            int[] w_array = data.Split(' ').Select(int.Parse).ToArray();
            for(int j=0;j<n;j++){
                array1[i,j] = w_array[j];
            }
        }
        for(int k = 0;k<5;k++){
            for(int l=0;l<n;l++){
                int num = array1[k,l];
                if(l == 0){
                    ans = ans + num.ToString();
                } else {
                    ans = ans + " " + num.ToString();
                }
            }
            Console.WriteLine(ans);
            ans = "";
        }
    }
}