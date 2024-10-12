using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        for(int i=1;i<=100;i++){
            if(i % 3 == 0 && i % 5 == 0){
                Console.WriteLine("FizzBuzz");
            } else if (i % 3 == 0){
                Console.WriteLine("Fizz");
            } else if ( i % 5 == 0){
                Console.WriteLine("Buzz");
            } else {
                Console.WriteLine(i);
            }
        }
    }
}
