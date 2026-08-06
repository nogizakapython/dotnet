using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        // 入力例（long型を超える巨大な数値でもOK）
        string number = Console.ReadLine(); 

        // 先頭の桁数を計算（3の倍数でない場合の余り）
        int firstGroupLength = number.Length % 3;
        if(firstGroupLength == 0) {
            firstGroupLength = 3;
        }    

        StringBuilder sb = new StringBuilder();
        
        // 最初のグループを追加
        sb.Append(number.Substring(0, firstGroupLength));

        // 残りの文字を3桁ずつ追加
        for (int i = firstGroupLength; i < number.Length; i += 3)
        {
            sb.Append(",");
            sb.Append(number.Substring(i, 3));
        }

        string ans = sb.ToString();

        Console.WriteLine(ans); 
        
    }

    
    
}