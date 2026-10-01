using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        char[] array1 = new char[n];
        int l = Int32.Parse(Console.ReadLine());
        StringBuilder ans = new StringBuilder();
        
        for(int i = 0;i<l ; i++){
            var data = Console.ReadLine();
            var w_array = data.Split(' ');
            int insert_p = Int32.Parse(w_array[0]);
            char c1 = Char.Parse(w_array[1]);
            array1[insert_p - 1] = c1;
        }
        string other_c = Console.ReadLine();
        char c3 = char.Parse(other_c);
        
        for(int m = 0;m < n;m++){
            char c2 = array1[m];
            if(c2 == '\0')  {
                c2 = c3;
            }
            ans.Append(c2);    
        }
        Console.WriteLine(ans);
        
    }
}