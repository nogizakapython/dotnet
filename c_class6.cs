using System;

public class User {
    private string name = "me!";
    public string Name { 
        get {return this.name;}
        set { this.name = value;}
    }    
    public User() {
        
    }
    public User(string name) {
        this.name = name;
    }
    public void ShowName(){
        Console.WriteLine("私は{0}です",this.name);
    }
    
}

class MyApp {
    static void Main(string[] args){
        User user = new User();
        user.ShowName();
        User user1 = new User("taguchi");
        user1.ShowName();
        User user2 = new User();
        user2.Name = "tanaka";
        user2.ShowName();
        user2.Name = "takayama";
        user2.ShowName();

    }
}