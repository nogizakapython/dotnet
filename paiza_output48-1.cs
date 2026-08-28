using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 9; i++)
        {
            string line = "";
            int num = 0;
            for (int j = 1; j <= 9; j++)
            {
                // 2桁になるよう半角スペース埋めで数値を作成
                num = i * j;
                line += num.ToString().PadLeft(2,' ');

                // 横の数値間には " | " を挿入
                if (j < 9)
                {
                    line += " | ";
                }
            }

            // 行を出力
            Console.WriteLine(line);

            // 縦の数値間（最終行以外）に "=" を上の行と同じ文字数分だけ出力
            if (i < 9)
            {
                Console.WriteLine(new string('=', line.Length));
            }
        }
    }
}
