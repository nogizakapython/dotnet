using System;

// インデクサ
class Team {
    private string[] members = new string[3];
    public string this[int i]{
        get { return this.members[i];}
        set { this.members[i] = value;}
    }
}

class MyApp {
    static void Main(){
        Team giants = new Team();
        giants[0] = "dotinstall";
        giants[1] = "progate";
        giants[2] = "paiza";
        
        for(int j=0;j<3;j++){
            Console.WriteLine(giants[j]);
        }    
    }
}