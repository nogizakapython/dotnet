using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        var array1 = s.Split(' ');
        var s1 = array1[0];
        var s2 = array1[1];
        var array2 = s1.Split('/');
        var array3 = s2.Split(':');
        foreach (var d1 in array2){
            Console.WriteLine(d1);
        }
        foreach ( var d2 in array3){
            Console.WriteLine(d2);

        }


    }
}
