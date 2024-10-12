using System;

struct Point {
  public int X { get;set;}
  public int Y { get;set;}
  public Point(int x,int y){
    X = x;
    Y = y;
  }
  public void GetInfo {

    Console.WriteLine(X);
  }

}
class Mytest1 {
  static void Main(){
    Point p1 = new Point(5,3);
    Point p2 = new Point(12,4);
    p1.GetInfo();
    p2.GetInfo();
  }
}

