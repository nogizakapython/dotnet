using System;
// リストを使用するクラスを呼び出す
using System.Collections.Generic;
using System.Linq;
// ファイルの読み書きのためのライブラリを呼び出す
using System.IO;
using System.Text;

namespace Sample
{
    class Sample
    {
        static void Main()
        {   
            // ファイル名を定義
            string file_name = "sakamichi.txt";
            // EIDリストの定義
            var titlelist = new List<string>();
            // StreamReaderクラスを読み込むファイル名とエンコードを指定してインスタンス化する
            StreamReader sr = new StreamReader(file_name, Encoding.GetEncoding("utf-8"));
            // 配列の要素の0番目を指定する変数
            int target = 0;
            while (sr.Peek() != -1)
            {
                // ファイルを1行ずつ読み込み、リストに追加する
                string eid = sr.ReadLine();
                titlelist.Add(eid);
            }

            sr.Close();
            // お題リストの要素をシャッフルする
            titlelist = titlelist.OrderBy(a => Guid.NewGuid()).ToList();

            Console.WriteLine("-----乃木坂に関するお題を１つ表示します-----");
            Console.WriteLine(titlelist[target]);
            
           
        }
    }
}