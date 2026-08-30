using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = Int32.Parse(Console.ReadLine());
        var data = Console.ReadLine();
        var array1 = data.Split(' ');
        int k = Int32.Parse(array1[0]);
        int m = Int32.Parse(array1[1]);
        var supply = Console.ReadLine();
        var array2 = supply.Split(' ');
        int k_account = 0;
        int money_account = 0;
        foreach(var d in array2){
            int money = Int32.Parse(d);
            if(money > k){
                k_account += 1;
            }
            money_account += money;

        }
        if((k_account >= 3) && (money_account >= m)){
            Console.WriteLine("silver");
        } else {
            Console.WriteLine("bronze");
        }


    }
}
