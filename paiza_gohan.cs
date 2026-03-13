using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string line = Console.ReadLine();
        string[] array1 = line.Split(' ');
        int H = Int32.Parse(array1[0]);
        int M = Int32.Parse(array1[1]);
        if((H >= 7) && (H < 13)){
            Console.WriteLine("lunch");
        } else if ((H >= 13) &&  (H < 19))  {
            Console.WriteLine("dinner");
        } else {
            Console.WriteLine("breakfast");
        } 
        
        // Console.WriteLine("XXXXXX");
    }
}