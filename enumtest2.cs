using System;

enum Direction {
    Stay = 0,
    Right = 1,
    Left = -1,
}

class EnumTest {
    static void Main(){
        Direction dir = Direction.Right;
        Console.WriteLine((int)Direction.Right);

        switch(dir) {
            case Direction.Stay:
                //そのまま
                break;
            case Direction.Right:
                //右へ
                break;
            case Direction.Left:
                //左へ
                break;    

        }
    }


}