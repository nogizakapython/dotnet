using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！

        for(int i = 1;i<=9;i++){
            string ans = "";
            int num = 0;
            for(int j = 1;j<=9;j++){
                    num = i * j;
                    if(j == 9){
                        ans = ans +  num.ToString().PadLeft(2,' ');
                    } else {
                        ans = ans +  num.ToString().PadLeft(2,' ') + " | ";
                    }
            }
            Console.WriteLine(ans);
            if (i < 9){
                Console.WriteLine("==========================================");
            }
        }


    }
}
