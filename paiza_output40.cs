using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        for(int i=0;i<n;i++){
            var d = Console.ReadLine();
            var array1 = d.Split(' ');
            double num = Double.Parse(array1[0]);
            int keta = Int32.Parse(array1[1]);
            string ans;
            if(keta == 1){
                ans = num.ToString("0.0");
            } else if (keta == 2){
                ans = num.ToString("0.00");
            } else if (keta == 3){
                ans = num.ToString("0.000");
            } else {
                ans = num.ToString("0.0000");
            }
            Console.WriteLine(ans);
        }
        
    }
}