using System;

// 객체의 크기를 비교 하는 함수는 "CompareTo" 로 하기로 하자!!
// => 인터페이스로 약속하자!!
// => 타입 만들때 인터페이스를 구현하기로 약속하면 이름이 동일 함을 보장할수 있다.
/*
// C# 1.0 에는 Generic 문법이 없었습니다.
// 그래서 인터페이스 만들때 함수인자로 "object" 를 많이 사용했습니다.
// => Boxing/Unboxing 현상이 많이 나타납니다. 성능저하..
interface IComparable
{
    int CompareTo(object obj);
}

// C# 2.0 에서 Generic 문법이 도입되었습니다.
// => 상당수의 인터페이스를 Generic 버전으로 추가로 설계했습니다.
interface IComparable<T>
{
    int CompareTo(T obj);
}
*/

struct Point : IComparable, IComparable<Point>
{
    public int x;
    public int y;
    public Point(int a = 0, int b = 0) { x = a; y = b; }

    public int CompareTo(object obj)
    {                         
         Point pt = (Point)obj;
        return x.CompareTo(pt.x);
    }

    public int CompareTo(Point pt)
    {
        return x.CompareTo(pt.x);
    }
}
class Program
{
    public static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(1, 1); 

        int ret = p1.CompareTo(p2);

        Foo(p2); // IComarable<T> 만 구현했다면 에러!!
                 // IComarable, IComarable<T> 둘다 구현했다면 에러아님.
    }

    // 오래전에 만들어둔 메소드
    public static void Foo(IComparable p)
    {

    }
}


