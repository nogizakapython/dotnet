using System;

class Program
{
    static void Main()
    {
        // 2次元配列の宣言と初期化
        string[] array1 = new string[] {"1 2 3","4,5,6","8,1,3"};
        
        
        // 行数の取得（第0次元の長さを取得）
        
        int n = array1.Length;

        // 出力
        Console.WriteLine(n);
    }
}