using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample701
{
    class Person
    {
        //  名前（フィールド）
        private string name = "";
        
        //  情報の設定
        public void SetAgeAndName(string name)
        {
            this.name = name;
        
        }
        //  情報の表示（メソッド）
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前：{0} ", name);
        }
        //  情報の設定
        public string Name
        {
            set { name = value;  }
            get { return name;  }
        }
        //  情報の設定
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] array1 = new Person[2];
            for (int i=0;i<2;i++){
                array1[i] = new Person();
                if (i == 0){
                    array1[i].Name = "佐藤美佐子" ;
                } else {
                    array1[i].Name = "白濱智子";
                }   
            }

            foreach(Person str1 in array1){
                Console.WriteLine("名前 : {0}",str1.Name);
            } 
            
        }
    }
}