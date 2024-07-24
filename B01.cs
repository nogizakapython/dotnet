// 正方形の面積を計算するプログラム
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B01
{
    class Program
    {

        
        static void Main(string[] args){
            int A = 0;
            int B = 0;
            int correct_count = 0;
            while(true)
            {
                Console.WriteLine("A、Bとも1以上100以下の整数を入力してください");
                try
                {  
                    A = int.Parse(Console.ReadLine());
                    if((A < 1) || (A > 100)){
                        Console.WriteLine("指定された範囲の数字を入力してください");
                    } else {
                        correct_count += 1;
                    }
                    
                    B = int.Parse(Console.ReadLine());
                    if((B < 1) || (B > 100)){
                        Console.WriteLine("指定された範囲の数字を入力してください");
                    } else {
                        correct_count += 1;
                    }
                    if (correct_count == 2){
                        break;
                    } else {
                        correct_count = 0;
                    }

                }
                catch(FormatException ){
                        Console.WriteLine("整数以外は入力しないでください");
                }
                

               
    
            }
            double ans;
            ans = A + B; 
            Console.WriteLine(ans);
        }    
    }
}    