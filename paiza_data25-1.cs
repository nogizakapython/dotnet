using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();

        // 1. ミス3の修正: 小数点が2つ以上ある場合、2つ目以降を削除する
        int firstDotIdx = s.IndexOf('.');
        if (firstDotIdx != -1)
        {
            string beforeFirstDot = s.Substring(0, firstDotIdx + 1);
            string afterFirstDot = s.Substring(firstDotIdx + 1);
            // 2つ目以降の小数点（'.'）をすべて空文字に置き換える
            s = beforeFirstDot + afterFirstDot.Replace(".", "");
        }

        // 2. ミス1 & ミス2の修正
        firstDotIdx = s.IndexOf('.');
        if (firstDotIdx != -1)
        {
            string integerPart = s.Substring(0, firstDotIdx);
            string decimalPart = s.Substring(firstDotIdx + 1);

            // ミス1: 整数部分の先頭の不要な「0」を削除
            integerPart = integerPart.TrimStart('0');
            if (integerPart == "") integerPart = "0"; // すべて消えた場合は "0" にする

            // ミス2: 小数部分の末尾の不要な「0」を削除
            decimalPart = decimalPart.TrimEnd('0');

            // 小数部分がすべて消えた場合は整数部分のみ、残っている場合は結合して出力
            if (decimalPart == "")
            {
                Console.WriteLine(integerPart);
            }
            else
            {
                Console.WriteLine(integerPart + "." + decimalPart);
            }
        }
        else
        {
            // 整数のみの場合（ミス1の処理）
            string integerPart = s.TrimStart('0');
            if (integerPart == "") integerPart = "0";
            Console.WriteLine(integerPart);
        }
    }
}