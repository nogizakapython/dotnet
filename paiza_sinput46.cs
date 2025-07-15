using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int num1 = Int32.Parse(Console.ReadLine());

        for(int i=0;i<num1;i++){
            var data = Console.ReadLine();
            var array1 = data.Split(' ');
            int leng1 = array1.Length;
            var ans = "";
            for(int j=1;j<leng1;j++){
                int k = leng1 - 1;
                if(j == k) {
                    ans = ans + array1[j];
                } else {
                    ans = ans + array1[j] + " ";
                }

            }
            Console.WriteLine(ans);

        }

    }
}
