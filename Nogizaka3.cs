using System;

class Member {
    public string name;
    
    public Member(string name){
        this.name = name;
        // Console.WriteLine("Hi,{0}",this.name);
    }

    public Member() {
        this.name = "梅澤美波";
    
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
        
    }
}