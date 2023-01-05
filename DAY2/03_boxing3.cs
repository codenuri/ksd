using System;


// object 멤버 Equals        : 인자로 object를 가진다. 값 타입일때 Boxing 발생 
// IEquatable<T> 멤버 Equals : 인자로 T를 가진다.Boxing 없다.

struct Point : IEquatable<Point>
{
    public int x;
    public int y;
    public Point(int a = 0, int b = 0) { x = a; y = b; }

    // object 로 부터 물려 받은 Equals 기본 구현
    // 참조 타입 : 동일 객체인가 ?
    // 값   타입 : 객체가 차지하는 메모리 내용 자체를 비교.

    // 기본 구현을 변경하려면 Equals 를 재정의 하면 됩니다.
    public override bool Equals(object obj)
    {
        Point pt = (Point)obj;

        return x == pt.x; // x 값만 동일하면 true...
    }

    public bool Equals(Point other)
    {
        return x == other.x;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 1);

        if (p1.Equals(p2))
        {
            Console.WriteLine("Same");
        }
        else
            Console.WriteLine("not Same");

        int n = 0;
    }
}