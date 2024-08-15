using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Nogizaka5
{

    class Member {
        private string name;

        public string Name {
            get { return this.name;}
            set { this.name = value;}
        }
    
        public Member(string name){
            this.name = name;
            // Console.WriteLine("Hi,{0}",this.name);
        }

        public Member() : this("梅澤美波"){
    
        }

        public void SayName(){
            Console.WriteLine("私は{0}です。",this.name);
        }
    }

    class MyApp {
        static void Main(string[] args){
            Member m1 = new Member();
            m1.SayName();
            Member m2 = new Member("遠藤さくら");
            m2.SayName();
            Member m3 = new Member();
            m3.Name = "与田祐希";
            m3.SayName();
        }
    }
}    