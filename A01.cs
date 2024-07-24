// 正方形の面積を計算するプログラム
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01
{
    class Program
    {
        static void Main(string[] args){
            int num;
            while(true)
            {
                Console.WriteLine("1以上100以下の整数を入力してください");
                try
                {  
                    num = int.Parse(Console.ReadLine());
                    if((num < 1) || (num > 100)){
                        Console.WriteLine("1以上100以下の整数を入力してください");
                    } else {
                        break;
                    }
                }
                catch(FormatException ){
                        Console.WriteLine("整数以外は入力しないでください");
                }    
            }
            double S;
            S = Math.Pow(num,2); 
            Console.WriteLine(S);
        }    
    }
}    