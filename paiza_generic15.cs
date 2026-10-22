using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[][] array1 = new int[][]
        {
            new int[] {1,3,5,7},
            new int[] {8,1,3,8}
        };

        string ans = "";
        for(int i=0 ; i < 2;i++){
            for(int j = 0;j<4;j++){
                int d = array1[i][j];
                if( j == 0){
                    ans = ans + d.ToString();
                } else {
                    ans = ans + " " + d.ToString();
                }
            }
            Console.WriteLine(ans);
            ans = "";
        }
    }
}
