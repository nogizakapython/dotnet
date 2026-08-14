using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var data1 = Console.ReadLine();
        var array1 = data1.Split(' ');
        var data2 = Console.ReadLine();
        var array2 = data2.Split(' ');
        var data3 = Console.ReadLine();
        var array3 = data3.Split(' ');
        
        int array2_leng = array2.Length;
        int array3_leng = array3.Length;
        
        int start_num = 0;
        int end_num = 0;
        string ans = "";
        for(int i=0;i<array3_leng;i++){
            int value1 = Int32.Parse(array3[i]);
            end_num = end_num + value1;
            for(int j = start_num ;j < end_num;j++){
                if(j == end_num - 1){
                    ans = ans + array2[j];
                    Console.WriteLine(ans);
                    ans = "";
                } else {
                    ans = ans + array2[j] + " ";
                }
            }
            start_num = start_num + value1;
            
        }
        
    }
}