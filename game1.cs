using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Sample406
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("3回勝負のじゃんけんです");
            int c_win_count,m_win_count;
            c_win_count = 0;
            m_win_count = 0;
            
            // 無限ループ
            while(c_win_count < 2 && m_win_count < 2){
                int c_pro = rnd.Next(1,4);
                int m_pro;    
                Console.WriteLine("1:グー,2:チョキ,3:パーのどれか1つの数字を入力してください");
                while(true){
                    m_pro = int.Parse(Console.ReadLine());
                    if(m_pro < 1 || m_pro > 3){
                        Console.WriteLine("1,2,3どれかの数字を入力してください");
                    } else {
                        break;
                    }
                }
                
                if (m_pro == 1 && c_pro == 1) {
                    Console.WriteLine("あいこです。");
                } else if ((m_pro == 1 && c_pro == 2)){
                    Console.WriteLine("あなたの勝ちです。");
                    m_win_count += 1; 
                } else if ((m_pro == 1 && c_pro == 3)){
                    Console.WriteLine("あなたの負けです。");
                    c_win_count += 1;
                } else if (m_pro == 2 && c_pro == 2) {
                    Console.WriteLine("あいこです。");
                } else if ((m_pro == 2 && c_pro == 3)){
                    Console.WriteLine("あなたの勝ちです。");
                    m_win_count += 1; 
                } else if ((m_pro == 2 && c_pro == 1)){
                    Console.WriteLine("あなたの負けです。");
                    c_win_count += 1;
                } else if (m_pro == 3 && c_pro == 3) {
                    Console.WriteLine("あいこです。");
                } else if ((m_pro == 3 && c_pro == 1)){
                    Console.WriteLine("あなたの勝ちです。");
                    m_win_count += 1; 
                } else if ((m_pro == 3 && c_pro == 2)){
                    Console.WriteLine("あなたの負けです。");
                    c_win_count += 1;
                }           
            }
            if (m_win_count == 2) {
                Console.WriteLine("{0}勝{1}敗であなたの優勝です。",m_win_count,c_win_count);
            } else {
                Console.WriteLine("{0}勝{1}敗でコンピューターの優勝です。",m_win_count,c_win_count);    
            }
            
        }
    }
}
