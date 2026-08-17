using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        for(int i=0;i<n;i++){
            string ans;
            string d = Console.ReadLine();
            int keta = d.Length;
            switch(keta){
                case 1:
                    ans = "  " + d.ToString();
                    break;    
                case 2:
                    ans = " " + d.ToString();
                    break;
                default: 
                    ans = d.ToString();
                    break;
            }
            Console.WriteLine(ans);    
        }
        
    }
}