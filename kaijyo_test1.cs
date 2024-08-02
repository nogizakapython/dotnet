using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace kaijyo
{
    class AddCalc
    {
        //  数値
        protected int num;
        // 解答
        protected int ans;
        //  numのプロパティ
        public int Num
        {
            set { num = value; }
            get { return num; }
        }
    
        //  与えられた数から1まで加算する
        public void add()
        {   
            ans = 0;
            for(int i=num;i>1;i--){
                ans += num;
            }
            Console.WriteLine("{0}から1まで順に足すと{1}である。",num,ans);
        }
        
    }
    class MulCalc : AddCalc
    {
        //  階乗の計算
        public void mul()
        {
            ans = 1;
            for(int j=num;j>=1;j--){
                ans *= j;
            }
            Console.WriteLine("{0}から1まで順にかけると{1}である。",num,ans);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //  AddCalcクラスのインスタンス
            AddCalc c1 = new AddCalc();
            c1.Num = 7;
            // MulCalcクラスのインスタンス
            MulCalc c2 = new MulCalc();
            c2.Num = 7;
            //  結果を表示
            c2.add();
            c2.mul();
            
        }
    }
}