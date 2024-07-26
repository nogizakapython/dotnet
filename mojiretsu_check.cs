using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Mojiretsucheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("文章を入力してください");
            string sentence = Console.ReadLine();
            string sentence1 = sentence.Replace("Environment.NewLine","");
            int num = sentence1.Length;
            File.WriteAllText(@"mojiretsu.txt","貴方が入力した文章は" + num.ToString()+ "文字です。");
            System.Diagnostics.Process.Start(@"mojiretsu.txt");
        }
    }
}