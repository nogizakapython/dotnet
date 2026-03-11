using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string[] array1 = Console.ReadLine().Split(' ');
        
        int sum1 = 0;
        int min_score = 999999;
        int max_score = 0;
        foreach(string data in array1){
            int w_data;
            w_data = Int32.Parse(data);
            if(w_data < min_score) {
                min_score = w_data;
            }
            if(w_data > max_score) {
                max_score = w_data;
            }
            sum1 += w_data;
        }
        
        sum1 = sum1 - min_score - max_score;
        Console.WriteLine(sum1);
    }
}