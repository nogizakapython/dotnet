using System;

// delegate
delegate void MyDelegate();

class delegate1 {

    static void SayHi(){
        Console.WriteLine("hi");
    }

    static void SayHello(){
        Console.WriteLine("Hello");
    }


    static void Main(){
        MyDelegate ShowMessage;
        ShowMessage = SayHi;
        ShowMessage += SayHello;
        ShowMessage();


    }
}