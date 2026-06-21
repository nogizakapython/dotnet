using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        
        
        string ans = "";
        
        for(int i = 0; i < 10; i++)
        {
            string data = Console.ReadLine();
        　　if(i < 9){
                ans = ans + data + " | ";
            } else {
                ans = ans + data;
            }  
              
                
        }
        Console.WriteLine(ans);
    }
}