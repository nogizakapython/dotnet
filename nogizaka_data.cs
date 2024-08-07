using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Nogizaka_data
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> nogizaka_array = new HashSet<String>();
            //  データを追加
            nogizaka_array.Add("梅澤美波");
            nogizaka_array.Add("久保史緒里");
            nogizaka_array.Add("与田祐希");
            nogizaka_array.Add("与田祐希");
            nogizaka_array.Add("遠藤さくら");
            nogizaka_array.Add("井上和");
            nogizaka_array.Add("遠藤さくら");
            nogizaka_array.Add("林瑠奈");
            Program.disp_data(nogizaka_array);
            //  データを削除
            nogizaka_array.Remove("与田祐希");   //  与田祐希を削除
            Program.disp_data(nogizaka_array);
            
            
        }
        public static void disp_data(HashSet<string> array1)
        {
            foreach(string data in array1)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("---------------");
        }
    }
}