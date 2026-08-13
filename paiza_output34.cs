using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        var data = Console.ReadLine();
        var array1 = data.Split(' ');
        foreach(var d in array1){
            int m = Int32.Parse(d);
            string ans = "";
            for(int i= 1;i<= m;i++){
                if(i == 1){
                    ans = ans + i.ToString();
                } else {
                    ans = ans + " " + i.ToString();
                }
            }
            Console.WriteLine(ans);
            ans = "";
        }
        //Console.WriteLine("XXXXXX");
    }
}