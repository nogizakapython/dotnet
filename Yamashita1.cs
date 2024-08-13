using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Yamashita1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "山下美月" , "山下瞳月", "山下葉留花" };
            //  配列の内容を表示
            try
            {
                for(int i = 0; i < 4; i++){
                    Console.WriteLine("data[" + i +"]=" + data[i]);
                }
            } catch(IndexOutOfRangeException){
                Console.WriteLine("配列の範囲を超えています。");
            }    
        }
    }
}