using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exam1
{
    class Car
    {
        public string name = "";
        public int air_sum = 0;


        public void ShowData(){
            Console.WriteLine("{0}の排気量は{1}ccです。",this.name,this.air_sum);
        } 

        public void SetData(string name,int air_sum){
            this.name = name;
            this.air_sum = air_sum;
        }
    }
    class Cartest
    {
        public static void Main(string[] args){
            Car c1,c2;
            c1 = new Car();
            c2 = new Car();
            c1.SetData("アルファード",2500);
            c2.SetData("ピクシスバン",660);
            c1.ShowData();
            c2.ShowData();
        }
    }
}    