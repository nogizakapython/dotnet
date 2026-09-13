using System;
using System.Text;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var d1 = Console.ReadLine();
        var array1 = d1.Split(' ');
        var d2 = Console.ReadLine();
        var array2 = d2.Split(' ');
        int n = Int32.Parse(array1[0]);
        int m = Int32.Parse(array1[1]);
        int ans = 0;
        for(int i= 0;i<m-1;i++){
            string b_word = array2[i];
            string a_word = array2[i+1];
            string b_ans = b_word.Substring(b_word.Length - n);
            string a_ans = a_word.Substring(0,n);
            //Console.WriteLine(b_ans);
            //Console.WriteLine(a_ans);
            if(b_ans == a_ans){
                ans += 1;
            }
        }
        if(ans == m - 1){
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }
}