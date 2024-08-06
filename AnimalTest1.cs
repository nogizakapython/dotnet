using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace AnimalTest1
{
    //  抽象クラス動物
    abstract class Animal
    {
        //  名前
        protected string name = "";
        //  吠える
        public abstract void Bark();
        //  動く
        public abstract void Move();
        //  名前を表示する
        public void ShowName()
        {
            Console.WriteLine("名前:{0}", name);
        }
    }
    //  犬クラス
    class Dog : Animal
    {
        public Dog()
        {
            name = "犬";
        }
        //  吠える
        public override void Bark()
        {
            Console.WriteLine("ワンワン");
        }
        //  動く
        public override void Move()
        {
            Console.WriteLine("歩く");
        }
    }
    // 猿クラス
    class Monkey : Animal
    {
        public Monkey()
        {
            name = "猿";
        }
        //  吠える
        public override void Bark()
        {
            Console.WriteLine("キーキー");
        }
        //  動く
        public override void Move()
        {
            Console.WriteLine("木に登る");
        }
    }

    // 猫クラス
    class Cat : Animal
    {
        public Cat()
        {
            name = "猫";
        }
        //  吠える
        public override void Bark()
        {
            Console.WriteLine("ニャーニャー");
        }
        //  動く
        public override void Move()
        {
            Console.WriteLine("走る");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  Animalクラスのオブジェクトの配列を生成
            Animal[] animals = new Animal[3];
            animals[0] = new Dog();     //  犬クラスのインスタンス生成
            animals[1] = new Monkey();  // 猿クラスのインスタンスの生成
            animals[2] = new Cat();
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].ShowName();
                animals[i].Move();
                animals[i].Bark();
                Console.WriteLine("------------");
            }
        }
    }
}