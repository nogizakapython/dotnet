using System;

class Program
{
    static void Main()
    {
        // 1行分の入力を読み込む（例："3 5" のような形式を想定）
        var line = Console.ReadLine();
        
        // 空白文字で分割して配列にする
        var array1 = line.Split(' ');
        
        // 最初の要素を n（ループ回数）、次の要素を m（桁数指定）にそれぞれ変換
        int n = Int32.Parse(array1[0]);
        int m = Int32.Parse(array1[1]);
        
        // n 回のループ処理
        for (int i = 0; i < n; i++)
        {
            // 出力用文字列を初期化
            string ans = "";
            
            // 1行分の入力を整数 d に変換
            int d = Int32.Parse(Console.ReadLine());
            
            // d を文字列に変換し、全体を m 文字分の幅に合わせて左寄せ（左側にスペースを追加）
            ans = d.ToString().PadLeft(m);
            
            // 整形した文字列を出力
            Console.WriteLine(ans);
        }
        
        
    }
}