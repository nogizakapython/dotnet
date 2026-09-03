using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        int H = Int32.Parse(array1[0]);
        int W = Int32.Parse(array1[1]);
        string A = array1[2];
        string B = array1[3];
        for(int i=0;i<H;i++){
            string ans = "";
            for(int j=0;j<W;j++){
                if(j == W - 1){
                    ans = ans + "(" + A + ", " + B + ")";
                    
                } else {
                    ans = ans + "(" + A + ", " + B + ")|";
                }
            }
            Console.WriteLine(ans);
            if(i < H - 1){
                Console.WriteLine("========================");
            }    
        }
        //Console.WriteLine("XXXXXX");
    }
}    