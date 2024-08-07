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
            List<String> hinata_array = new List<String>();
            //  データを追加
            hinata_array.Add("佐々木久美");
            hinata_array.Add("加藤史帆");
            hinata_array.Add("小坂菜緒");
            hinata_array.Add("丹生明里");
            hinata_array.Add("正源司陽子");
            hinata_array.Add("東村芽依");
            hinata_array.Add("上村ひなの");
            Program.disp_data(hinata_array);
            //  データを削除
            hinata_array.RemoveAt(1);   //  １番目を削除
            hinata_array.Remove("丹生明里"); //　丹生明里を削除
            hinata_array.RemoveAt(3);        //  3番目のデータを削除
            Program.disp_data(hinata_array);
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