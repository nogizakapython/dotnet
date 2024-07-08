using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nogi1
{
    class nogizaka1
    {
        public static void Main(string[] args){
            int num = 0;
            while(true){
                Console.WriteLine("人数を２人以上１０人未満で入力してください。");
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                    if ((num < 2) || (num > 10)){
                        Console.WriteLine("2以上10以下の整数で入力してください");
                    } else {
                        break;
                    }
                }        
                catch (Exception)
                {
                    Console.WriteLine("数値以外を入力しないでください");
                }
                
            }
            
            string[] data = new string[num];
            for(int i=0;i<num;i++){
                Console.WriteLine("乃木坂メンバーを1人ずつ入力してください");
                data[i] = Console.ReadLine();
            }

            foreach(string name in data)
            {
                Console.WriteLine(name);
            }
        }
    }
}