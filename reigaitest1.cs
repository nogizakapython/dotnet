using System;

class ReigatTest1 {
    static void Div(int a,int b){
        try{
            Console.WriteLine(a / b);
        } catch (System.DivideByZeroException){
            Console.WriteLine("0で割ってはいけません");
        }    
    
    }
    static void Main(){
        Div(10,0);
    }


}