// 世界のナベアツプログラム
// １～1000に拡張
//  New create 2024/7/24


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Nabeatsu
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag1 = 0;
            for(int i=1;i<=1000;i++){
                if(i % 3 == 0){
                    flag1 += 1;
                }
                if(i % 10 == 3){
                    flag1 += 1;
                }
                if(i / 10 % 10 == 3){
                    flag1 += 1;
                }
                if(i / 100 == 3){
                    flag1 += 1;
                }
                if(flag1 > 0){
                    Console.WriteLine(i);
                }
                flag1 = 0;
                
            }
        }
    }
}