using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Hinatazaka_data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> sakura_array = new List<String>();
            //  データを追加
            sakura_array.Add("山下瞳月");
            sakura_array.Add("松田里奈");
            sakura_array.Add("小池美波");
            sakura_array.Add("田村保乃");
            sakura_array.Add("森田ひかる");
            sakura_array.Add("守屋麗奈");
            sakura_array.Add("大園玲");
            sakura_array.Add("山﨑天");
            sakura_array.Add("遠藤理子");
            Program.disp_data(sakura_array);
            //  データを削除
            sakura_array.Sort();   //  １番目を削除
            Program.disp_data(sakura_array);
            // データ存在確認
            bool result1 = sakura_array.Exists(n => n == "長濱ねる");
            Console.WriteLine(result1);
            // データ存在確認
            Console.WriteLine(sakura_array.Exists(str1 => str1 == "森田ひかる"));
        }
        public static void disp_data(List<string> array1)
        {
            foreach(string data in array1)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("---------------");
        }
    }
}