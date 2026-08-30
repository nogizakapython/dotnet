using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var array1 = line.Split(' ');
        int n = 0;
        foreach(var data in array1){
            int d =0;
            if(n == 0){
                if(data == "x"){
                    Console.WriteLine(data);
                } else {
                    d = Int32.Parse(data);
                    Console.WriteLine(d + 1);
                }
            } else if (n == 2){
                if(data == "x"){
                    Console.WriteLine(data);
                } else {
                    d = Int32.Parse(data);
                    Console.WriteLine(d + 1);
                }

            } else if (n == 4){
                if(data == "x"){
                    Console.WriteLine(data);
                } else {
                    d = Int32.Parse(data);
                    Console.WriteLine(d + 1);
                }
            } else {
                Console.WriteLine(data);
            }

            n += 1;

        }

        //Console.WriteLine("XXXXXX");
    }
}
