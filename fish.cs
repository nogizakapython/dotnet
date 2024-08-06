using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Fish1{
    //  抽象クラス動物
    abstract class Fish
    {
        //  名前
        protected string name = "";
        //  泳ぐ
        public abstract void Swim();
        //  名前を表示する
        public void ShowName()
        {
            Console.WriteLine("名前:{0}", name);
        }
        public Fish()
        {

        }
        public Fish(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name;}
            set { name = value;}
        }

    }


    //  さんまクラス
    class Pike : Fish
    {
        public Pike()
        {
            name = "さんま";
        }
        //  吠える
        public override void Swim()
        {
            Console.WriteLine("さんまが泳ぐ");
        }
        
    }
    
    //  さんまクラス
    class Bonito : Fish
    {
        public Bonito()
        {
            name = "カツオ";
        }
        //  吠える
        public override void Swim()
        {
            Console.WriteLine("カツオが泳ぐ");
        }
        public Bonito(string name)
        {
            this.name = name;
            
        }
        
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            //  Animalクラスのオブジェクトの配列を生成
            Fish[] fishes = new Fish[2];
            fishes[0] = new Pike();     //  さんまクラスのインスタンス生成
            fishes[1] = new Bonito();   //  カツオクラスのインスタンス生成   
            
            for (int i = 0; i < fishes.Length; i++)
            {
                fishes[i].ShowName();
                fishes[i].Swim();
                Console.WriteLine("------------");
            }
            //  Fishクラスのオブジェクトの配列を生成
            
            Fish[] fishes1 = new Fish[1];
            fishes1[0] = new Bonito("カツオ");     // カツオクラスのインスタンス生成
            
            for (int i = 0; i < fishes1.Length; i++)
            {
                fishes1[i].ShowName();
                fishes1[i].Swim();
                Console.WriteLine("------------");
            }
        }
    }
}