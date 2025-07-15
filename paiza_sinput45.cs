using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var data1 = Console.ReadLine();
        var array1 = data1.Split(' ');
        int num1 = Int32.Parse(array1[0]);
        int num2 = Int32.Parse(array1[1]);
        for(int i=0;i<num1;i++){
            string data = Console.ReadLine();
            Console.WriteLine(data);
        }
    }
}
