using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！

        // 1行目: "A B" 形式で入力（上底と下底）
        string line = Console.ReadLine();
        // スペース区切りで分割
        string[] array1 = line.Split(' ');
        // 上底
        int A = Int32.Parse(array1[0]);
        // 下底
        int B = Int32.Parse(array1[1]);
        // 高さ
        int H = Int32.Parse(Console.ReadLine());

        // 台形の面積: (上底 + 下底) × 高さ ÷ 2
        Console.WriteLine((A + B) * H / 2);
    }
}
