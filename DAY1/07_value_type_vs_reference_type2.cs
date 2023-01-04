using System;

// 핵심 5. equality

class Point
{
    public int x;
    public int y;
    public Point(int a, int b) { x = a; y = b; }

    public override bool Equals(object obj)
    {
        Point pt = (Point)obj;

        return x == pt.x && y == pt.y;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 1); 
        Point p2 = new Point(1, 1);

        // 객체의 상등 조사
        // 1. == 연산자
        Console.WriteLine($"{p1 == p2}"); // 참조가 동일한가?(즉, 동일한 객체인가?)
                                          // 따라서, False

        // 2. object 로 부터 물려받은 Equals() 메소드 사용
        // => 기본 구현은 GetHashCode()로 조사, 동일한 객체인지를 조사
        // => 메소드 재정의 하면 원하는 구현으로 변경 가능
        Console.WriteLine($"{p1.Equals(p2)}");
    }
}




