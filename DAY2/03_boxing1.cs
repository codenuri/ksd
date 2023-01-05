using System;

// boxing / unboxing 개념
// value type   // 컴파일러는 아래 처럼 object 로 부터 파생 되도록 코드를 변경합니다.
struct Point    // : object
{
    public int x;
    public int y;
    public Point(int a = 0, int b = 0) { x = a; y = b; }
}
class Program
{
    public static void Main()
    {
        // value type 이므로 stack 에 놓인다.
        Point p1 = new Point(0, 0);       

        // C#의 모든 타입은 object 로 부터 파생 됩니다.
        // 그런데, object 는 클래스(참조타입)입니다.
        object o1 = p1; // 1. p1의 복사본을 힙에 생성
                        // 2. o1은 힙에 있는 복사본을 가리키게 됩니다.
                        // "Boxing" 이라는 현상 입니다.

        Point p2 = (Point)o1; // Unboxing

    }
}