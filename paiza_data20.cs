using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        var array1 = s.Split('/');
        var s1 = array1[3];
        var array2 = s1.Split(':');
        int n = 3;
        for(int i=0;i<n;i++){
            Console.WriteLine(array1[i]);
        }
        foreach(var d2 in array2){
            Console.WriteLine(d2);
        }

        //Console.WriteLine("XXXXXX");
    }
}
