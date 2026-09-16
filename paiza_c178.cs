using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var w_array1 = line.Split(' ');
        int n = Int32.Parse(w_array1[0]);
        int c = Int32.Parse(w_array1[1]);
        var data = Console.ReadLine();
        var w_array2 = data.Split(' ');
        var array1 = new List<int>();
        int ans = 0;
        int count = 0;
        int i = (int)(n / 2);
        
        foreach(var temp_data in w_array2){
            int t_data = Int32.Parse(temp_data);
            array1.Add(t_data);
        }
        
        array1.Sort();
        array1.Reverse();
        
        foreach(int num in array1){
            if(num >= c){
                count += 1;
            }
        }
        
        if( count > i){
            Console.WriteLine(ans);
        } else {
            ans = c - array1[i];
            Console.WriteLine(ans);
        }
       
        
    }
}