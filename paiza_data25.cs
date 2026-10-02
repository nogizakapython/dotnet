using System;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        var array1 = s.Split('.');
        int el = array1.Length;
        long num1 = long.Parse(array1[0]);
        StringBuilder sb = new StringBuilder();
        for(int i = 1;i<el ; i++){
            sb.Append(array1[i]);
        }
        string data2 = "0." + sb.ToString();
        //Console.WriteLine(data2);
        char[] data3 = data2.ToCharArray();
        int l1 = data3.Length;
        //Console.WriteLine(l1);
        //Console.WriteLine(data3);
        bool flag1 = false;
        string data4 = "";
        for(int j= 0 ; j < l1; j++){
            char c1 = data3[j];
            
            if (c1 == '.') {
                data4 +=  c1.ToString();
            }
            if ((c1 != '0') && (c1 != '.')){
                flag1 = true;
                data4 += c1.ToString();
            } else if ((c1 == '0' ) && (flag1 == false) ){
                data4 += c1.ToString();
            } 
            
        }
        //Console.WriteLine(data4);
        var array2 = data4.Split('.');
        string num2 = array2[1];
        Console.WriteLine(num1.ToString() + "." + num2.ToString());
        
    }
}