using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogizaka1
{
    //  デリゲート
    delegate void Operation(string str1,string str2);
    //  Calcクラス
    class Msg
    {
        public void concat1(string a, string b)
        {
            Console.WriteLine("{0}は{1}なのでかわいい", a, b);
        }
        public void concat2(string a, string b)
        {
            Console.WriteLine("{0}は{1}なのであざとい", a, b);
        }
    }
    //  Programクラス
    class Program
    {
        static void normal(string a, string b)
        {
            Console.WriteLine("{0}は{1}です。", a, b);
        }
        static void Main(string[] args)
        {
            Msg m = new Msg();
            //  デリゲートの設定
            Operation o1 = new Operation(normal);
            Operation o2 = new Operation(m.concat1);
            Operation o3 = new Operation(m.concat2);
            //  デリゲートで設定したメソッドの呼び出し
            o1("奥田いろは","乃木坂5期生");
            o2("井上和","センター");
            o3("一ノ瀬美空","必殺技を持ち");
        }
    }
}