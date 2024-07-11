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
        //  年齢（フィールド）
        private int age = 0;
        //  情報の設定
        public void SetAgeAndName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //  情報の表示（メソッド）
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前：{0} 年齢：{1}", name, age);
        }
        //  情報の設定
        public string Name
        {
            set { name = value;  }
            get { return name;  }
        }
        //  情報の設定
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1,p2;
            p1 = new Person();       //  一つ目のPersonクラスのメソッドのインスタンスを生成
            p2 = new Person();       //  二つ目のPersonクラスのメソッドのインスタンスを生成
            p1.SetAgeAndName("筒井あやめ",20);    //  フィールドnameに値を代入
            // p1.Age = 19;             //  フィールドageに値を代入
            p2.SetAgeAndName("佐々木久美", 29);   //  setAgeAndName()メソッドで、nameとageを設定
            Console.WriteLine("名前:{0} , 年齢:{1} ",p1.Name,p1.Age);
            Console.WriteLine("名前:{0} , 年齢:{1} ",p2.Name,p2.Age);
            
            
        }
    }
}