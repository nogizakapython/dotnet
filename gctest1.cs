using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace GCTest1
{
    class Connectstr
    {
        public string connect(string str1,int times)
        {   
            string ans = "";
            for(int i=0;i<times;i++){
                ans += str1;
            }
            return ans;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            string resultstr = "";            
            Connectstr p1 = new Connectstr();
            resultstr = p1.connect("秋元真夏",1000);
            Console.WriteLine("メモリ使用量（GC発動前）　：" + GC.GetTotalMemory(false));
            //  aの参照を解放
            p1 = null;
            Console.WriteLine("メモリ使用量（参照解除後）：" + GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("メモリ使用量（GC発動後）　：" + GC.GetTotalMemory(false));
        }
    }
}