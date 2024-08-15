using System;

public class User {
    private string name = "ななし";
    public string Name { 
        get {return this.name;}
        set { 
            
            if(value != ""){
                this.name = value;
            } 
        }
    }    
    
    
    public void ShowName(){
        Console.WriteLine("私は{0}です",this.name);
    }
    
}

class MyApp {
    static void Main(string[] args){
        User user = new User();
        user.ShowName();
        User user1 = new User();
        user1.Name = "taguchi";
        user1.ShowName();
        user1.Name = "";
        user1.ShowName();
        

    }
}