using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string data1 = Console.ReadLine();
        string[] array1 = data1.Split(' ');
        string data2 = Console.ReadLine();
        string[] array2 = data2.Split(' ');
        var array3 = new int[] {0,0,0,0,0};
        int i = 0;
        int sum = 0;
        foreach(string elem1 in array1){
            int num1;
            num1 = Int32.Parse(elem1);
            array3[i] = num1;
            i += 1;
        }
        for(int j=0;j<5;j++){
            int num2;
            num2 = array3[j];
            sum += num2;
            
        }
        int clear_num;
        clear_num = 0;
        for(int k=0;k<5;k++){
            int num3;
            string flag1;
            num3 = array3[k];
            flag1 = array2[k];
            if(flag1 == "o"){
                clear_num += num3;
            }
            
            
        }
        //Console.WriteLine(sum);
        //Console.WriteLine(clear_num);
        double ans;
        ans =(int) (((double)clear_num / (double)sum) * 100);
        Console.WriteLine(ans);
    }
}