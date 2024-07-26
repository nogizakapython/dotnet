// ライブラリを読み込む
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
            // 改行コードを取り除く
            string sentence1 = sentence.Replace("Environment.NewLine","");
            // 文字数を変数に取得する。
            int num = sentence1.Length;
            // 結果をテキストファイルに出力する。
            File.WriteAllText(@"mojiretsu.txt","貴方が入力した文章は" + num.ToString()+ "文字です。");
            // メモ帳で開く
            System.Diagnostics.Process.Start(@"mojiretsu.txt");
        }
    }
}