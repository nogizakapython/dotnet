using System;

enum Direction {
    Stay,
    Right,
    Left,
}

class EnumTest {
    static void Main(){
        Direction dir = Direction.Right;

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