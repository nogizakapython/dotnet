using System;

// インデクサ
class Member {
    private string[] members = new string[4];
    public string this[int i]{
        get { return this.members[i];}
        set { this.members[i] = value;}
    }
}

class Sakurazaka1 {
    static void Main(){
        Member sakura = new Member();
        sakura[0] = "田村保乃";
        sakura[1] = "森田ひかる";
        sakura[2] = "守屋麗奈";
        sakura[3] = "山﨑天";
        
        for(int j=0;j<4;j++){
            Console.WriteLine(sakura[j]);
        }    
    }
}